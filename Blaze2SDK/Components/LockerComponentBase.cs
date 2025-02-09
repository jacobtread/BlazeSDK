using BlazeCommon;

namespace Blaze2SDK.Components
{
    public static class LockerComponentBase
    {
        public const ushort Id = 20;
        public const string Name = "LockerComponent";
        
        public class Server : BlazeComponent<LockerComponentCommand, LockerComponentNotification, Blaze2RpcError>
        {
            public Server() : base(LockerComponentBase.Id, LockerComponentBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)LockerComponentCommand.createContent)]
            public virtual Task<NullStruct> CreateContentAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LockerComponentCommand.createSubContent)]
            public virtual Task<NullStruct> CreateSubContentAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LockerComponentCommand.confirmUpload)]
            public virtual Task<NullStruct> ConfirmUploadAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LockerComponentCommand.updateContentInfo)]
            public virtual Task<NullStruct> UpdateContentInfoAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LockerComponentCommand.deleteContent)]
            public virtual Task<NullStruct> DeleteContentAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LockerComponentCommand.copyContentReference)]
            public virtual Task<NullStruct> CopyContentReferenceAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LockerComponentCommand.bookmarkContentReference)]
            public virtual Task<NullStruct> BookmarkContentReferenceAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LockerComponentCommand.getContentInfo)]
            public virtual Task<NullStruct> GetContentInfoAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LockerComponentCommand.ListContent)]
            public virtual Task<NullStruct> ListContentAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LockerComponentCommand.getTopN)]
            public virtual Task<NullStruct> GetTopNAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LockerComponentCommand.getLeaderboardView)]
            public virtual Task<NullStruct> GetLeaderboardViewAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LockerComponentCommand.updateRating)]
            public virtual Task<NullStruct> UpdateRatingAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LockerComponentCommand.incrementUseCount)]
            public virtual Task<NullStruct> IncrementUseCountAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LockerComponentCommand.setOwnerGroup)]
            public virtual Task<NullStruct> SetOwnerGroupAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)LockerComponentCommand.removeOwnerGroup)]
            public virtual Task<NullStruct> RemoveOwnerGroupAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            
            public override Type GetCommandRequestType(LockerComponentCommand command) => LockerComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(LockerComponentCommand command) => LockerComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(LockerComponentCommand command) => LockerComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(LockerComponentNotification notification) => LockerComponentBase.GetNotificationType(notification);
            
        }
        
        public class Client : BlazeComponent<LockerComponentCommand, LockerComponentNotification, Blaze2RpcError>
        {
            public Client() : base(LockerComponentBase.Id, LockerComponentBase.Name)
            {
                
            }
            
            public override Type GetCommandRequestType(LockerComponentCommand command) => LockerComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(LockerComponentCommand command) => LockerComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(LockerComponentCommand command) => LockerComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(LockerComponentNotification notification) => LockerComponentBase.GetNotificationType(notification);
            
        }
        
        public static Type GetCommandRequestType(LockerComponentCommand command) => command switch
        {
            LockerComponentCommand.createContent => typeof(NullStruct),
            LockerComponentCommand.createSubContent => typeof(NullStruct),
            LockerComponentCommand.confirmUpload => typeof(NullStruct),
            LockerComponentCommand.updateContentInfo => typeof(NullStruct),
            LockerComponentCommand.deleteContent => typeof(NullStruct),
            LockerComponentCommand.copyContentReference => typeof(NullStruct),
            LockerComponentCommand.bookmarkContentReference => typeof(NullStruct),
            LockerComponentCommand.getContentInfo => typeof(NullStruct),
            LockerComponentCommand.ListContent => typeof(NullStruct),
            LockerComponentCommand.getTopN => typeof(NullStruct),
            LockerComponentCommand.getLeaderboardView => typeof(NullStruct),
            LockerComponentCommand.updateRating => typeof(NullStruct),
            LockerComponentCommand.incrementUseCount => typeof(NullStruct),
            LockerComponentCommand.setOwnerGroup => typeof(NullStruct),
            LockerComponentCommand.removeOwnerGroup => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandResponseType(LockerComponentCommand command) => command switch
        {
            LockerComponentCommand.createContent => typeof(NullStruct),
            LockerComponentCommand.createSubContent => typeof(NullStruct),
            LockerComponentCommand.confirmUpload => typeof(NullStruct),
            LockerComponentCommand.updateContentInfo => typeof(NullStruct),
            LockerComponentCommand.deleteContent => typeof(NullStruct),
            LockerComponentCommand.copyContentReference => typeof(NullStruct),
            LockerComponentCommand.bookmarkContentReference => typeof(NullStruct),
            LockerComponentCommand.getContentInfo => typeof(NullStruct),
            LockerComponentCommand.ListContent => typeof(NullStruct),
            LockerComponentCommand.getTopN => typeof(NullStruct),
            LockerComponentCommand.getLeaderboardView => typeof(NullStruct),
            LockerComponentCommand.updateRating => typeof(NullStruct),
            LockerComponentCommand.incrementUseCount => typeof(NullStruct),
            LockerComponentCommand.setOwnerGroup => typeof(NullStruct),
            LockerComponentCommand.removeOwnerGroup => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandErrorResponseType(LockerComponentCommand command) => command switch
        {
            LockerComponentCommand.createContent => typeof(NullStruct),
            LockerComponentCommand.createSubContent => typeof(NullStruct),
            LockerComponentCommand.confirmUpload => typeof(NullStruct),
            LockerComponentCommand.updateContentInfo => typeof(NullStruct),
            LockerComponentCommand.deleteContent => typeof(NullStruct),
            LockerComponentCommand.copyContentReference => typeof(NullStruct),
            LockerComponentCommand.bookmarkContentReference => typeof(NullStruct),
            LockerComponentCommand.getContentInfo => typeof(NullStruct),
            LockerComponentCommand.ListContent => typeof(NullStruct),
            LockerComponentCommand.getTopN => typeof(NullStruct),
            LockerComponentCommand.getLeaderboardView => typeof(NullStruct),
            LockerComponentCommand.updateRating => typeof(NullStruct),
            LockerComponentCommand.incrementUseCount => typeof(NullStruct),
            LockerComponentCommand.setOwnerGroup => typeof(NullStruct),
            LockerComponentCommand.removeOwnerGroup => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetNotificationType(LockerComponentNotification notification) => notification switch
        {
            _ => typeof(NullStruct)
        };
        
        public enum LockerComponentCommand : ushort
        {
            createContent = 1,
            createSubContent = 2,
            confirmUpload = 3,
            updateContentInfo = 4,
            deleteContent = 5,
            copyContentReference = 6,
            bookmarkContentReference = 7,
            getContentInfo = 8,
            ListContent = 9,
            getTopN = 10,
            getLeaderboardView = 11,
            updateRating = 12,
            incrementUseCount = 13,
            setOwnerGroup = 14,
            removeOwnerGroup = 15,
        }
        
        public enum LockerComponentNotification : ushort
        {
        }
        
    }
}
