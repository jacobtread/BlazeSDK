﻿using System.Net;
using System.Security.Cryptography.X509Certificates;
using Tdf;

namespace BlazeCommon
{
    public delegate void ConnectionDelegate(BlazeServerConnection connection);
    public delegate void ConnectionUnhandledRequestDelegate(BlazeServerConnection connection, ProtoFirePacket packet);
    public delegate void ConnectionOnErrorDelegate(BlazeServerConnection connection, Exception exception);
    public class BlazeServerConfiguration
    {
        public string Name { get; }
        public IPEndPoint LocalEP { get; }
        public X509Certificate? Certificate { get; set; }
        public ITdfEncoder Encoder { get; }
        public ITdfDecoder Decoder { get; }
        public int ComponentNotFoundErrorCode { get; set; }
        public int CommandNotFoundErrorCode { get; set; }
        public int ErrSystemErrorCode { get; set; }
        public ConnectionDelegate? OnNewConnection { get; set; }
        public ConnectionDelegate? OnDisconnected { get; set; }
        public ConnectionUnhandledRequestDelegate? OnUnhandledRequest { get; set; }
        public ConnectionOnErrorDelegate? OnError { get; set; }

        Dictionary<ushort, IBlazeComponent> _components;

        public BlazeServerConfiguration(string name, IPEndPoint endPoint, ITdfEncoder encoder, ITdfDecoder decoder)
        {
            Name = name;
            LocalEP = endPoint;
            Encoder = encoder;
            Decoder = decoder;
            _components = new Dictionary<ushort, IBlazeComponent>();

            //Taken from Blaze 3
            ComponentNotFoundErrorCode = 1073872896;
            CommandNotFoundErrorCode = 1073938432;
            ErrSystemErrorCode = 1073807360;
        }


        public bool AddComponent<TComponent>() where TComponent : IBlazeComponent, new()
        {
            TComponent component = new TComponent();
            return _components.TryAdd(component.Id, component);
        }

        public bool RemoveComponent(ushort componentId, out IBlazeComponent? component)
        {
            return _components.Remove(componentId, out component);
        }

        public IBlazeComponent? GetComponent(ushort componentId)
        {
            _components.TryGetValue(componentId, out IBlazeComponent? component);
            return component;
        }
    }
}
