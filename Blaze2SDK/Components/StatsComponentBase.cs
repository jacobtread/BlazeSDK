using Blaze2SDK.Blaze.Stats;
using BlazeCommon;

namespace Blaze2SDK.Components
{
    public static class StatsComponentBase
    {
        public const ushort Id = 7;
        public const string Name = "StatsComponent";
        
        public class Server : BlazeComponent<StatsComponentCommand, StatsComponentNotification, Blaze2RpcError>
        {
            public Server() : base(StatsComponentBase.Id, StatsComponentBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)StatsComponentCommand.getStatDescs)]
            public virtual Task<NullStruct> GetStatDescsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)StatsComponentCommand.getStats)]
            public virtual Task<NullStruct> GetStatsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)StatsComponentCommand.getStatGroupList)]
            public virtual Task<StatGroupList> GetStatGroupListAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)StatsComponentCommand.getStatGroup)]
            public virtual Task<StatGroupResponse> GetStatGroupAsync(GetStatGroupRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)StatsComponentCommand.getStatsByGroup)]
            public virtual Task<NullStruct> GetStatsByGroupAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)StatsComponentCommand.getDateRange)]
            public virtual Task<NullStruct> GetDateRangeAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)StatsComponentCommand.getEntityCount)]
            public virtual Task<NullStruct> GetEntityCountAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)StatsComponentCommand.updateStats)]
            public virtual Task<NullStruct> UpdateStatsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)StatsComponentCommand.wipeStats)]
            public virtual Task<NullStruct> WipeStatsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)StatsComponentCommand.getLeaderboardGroup)]
            public virtual Task<LeaderboardGroupResponse> GetLeaderboardGroupAsync(LeaderboardGroupRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)StatsComponentCommand.getLeaderboardFolderGroup)]
            public virtual Task<LeaderboardFolderGroup> GetLeaderboardFolderGroupAsync(LeaderboardFolderGroupRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)StatsComponentCommand.getLeaderboard)]
            public virtual Task<LeaderboardStatValues> GetLeaderboardAsync(LeaderboardStatsRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)StatsComponentCommand.getCenteredLeaderboard)]
            public virtual Task<LeaderboardStatValues> GetCenteredLeaderboardAsync(CenteredLeaderboardStatsRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)StatsComponentCommand.getFilteredLeaderboard)]
            public virtual Task<LeaderboardStatValues> GetFilteredLeaderboardAsync(FilteredLeaderboardStatsRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)StatsComponentCommand.getKeyScopesMap)]
            public virtual Task<KeyScopes> GetKeyScopesMapAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)StatsComponentCommand.getStatsByGroupAsync)]
            public virtual Task<NullStruct> GetStatsByGroupAsyncAsync(GetStatsByGroupRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)StatsComponentCommand.getLeaderboardTreeAsync)]
            public virtual Task<NullStruct> GetLeaderboardTreeAsyncAsync(GetLeaderboardTreeRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)StatsComponentCommand.getLeaderboardEntityCount)]
            public virtual Task<EntityCount> GetLeaderboardEntityCountAsync(LeaderboardEntityCountRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            
            public static Task NotifyGetStatsAsyncNotificationAsync(BlazeServerConnection connection, KeyScopedStatValues notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(StatsComponentBase.Id, (ushort)StatsComponentNotification.GetStatsAsyncNotification, notification, waitUntilFree);
            }
            
            public static Task NotifyGetLeaderboardTreeNotificationAsync(BlazeServerConnection connection, LeaderboardTreeNode notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(StatsComponentBase.Id, (ushort)StatsComponentNotification.GetLeaderboardTreeNotification, notification, waitUntilFree);
            }
            
            public override Type GetCommandRequestType(StatsComponentCommand command) => StatsComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(StatsComponentCommand command) => StatsComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(StatsComponentCommand command) => StatsComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(StatsComponentNotification notification) => StatsComponentBase.GetNotificationType(notification);
            
        }
        
        public class Client : BlazeComponent<StatsComponentCommand, StatsComponentNotification, Blaze2RpcError>
        {
            public Client() : base(StatsComponentBase.Id, StatsComponentBase.Name)
            {
                
            }
            
            public override Type GetCommandRequestType(StatsComponentCommand command) => StatsComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(StatsComponentCommand command) => StatsComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(StatsComponentCommand command) => StatsComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(StatsComponentNotification notification) => StatsComponentBase.GetNotificationType(notification);
            
        }
        
        public static Type GetCommandRequestType(StatsComponentCommand command) => command switch
        {
            StatsComponentCommand.getStatDescs => typeof(NullStruct),
            StatsComponentCommand.getStats => typeof(NullStruct),
            StatsComponentCommand.getStatGroupList => typeof(NullStruct),
            StatsComponentCommand.getStatGroup => typeof(GetStatGroupRequest),
            StatsComponentCommand.getStatsByGroup => typeof(NullStruct),
            StatsComponentCommand.getDateRange => typeof(NullStruct),
            StatsComponentCommand.getEntityCount => typeof(NullStruct),
            StatsComponentCommand.updateStats => typeof(NullStruct),
            StatsComponentCommand.wipeStats => typeof(NullStruct),
            StatsComponentCommand.getLeaderboardGroup => typeof(LeaderboardGroupRequest),
            StatsComponentCommand.getLeaderboardFolderGroup => typeof(LeaderboardFolderGroupRequest),
            StatsComponentCommand.getLeaderboard => typeof(LeaderboardStatsRequest),
            StatsComponentCommand.getCenteredLeaderboard => typeof(CenteredLeaderboardStatsRequest),
            StatsComponentCommand.getFilteredLeaderboard => typeof(FilteredLeaderboardStatsRequest),
            StatsComponentCommand.getKeyScopesMap => typeof(NullStruct),
            StatsComponentCommand.getStatsByGroupAsync => typeof(GetStatsByGroupRequest),
            StatsComponentCommand.getLeaderboardTreeAsync => typeof(GetLeaderboardTreeRequest),
            StatsComponentCommand.getLeaderboardEntityCount => typeof(LeaderboardEntityCountRequest),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandResponseType(StatsComponentCommand command) => command switch
        {
            StatsComponentCommand.getStatDescs => typeof(NullStruct),
            StatsComponentCommand.getStats => typeof(NullStruct),
            StatsComponentCommand.getStatGroupList => typeof(StatGroupList),
            StatsComponentCommand.getStatGroup => typeof(StatGroupResponse),
            StatsComponentCommand.getStatsByGroup => typeof(NullStruct),
            StatsComponentCommand.getDateRange => typeof(NullStruct),
            StatsComponentCommand.getEntityCount => typeof(NullStruct),
            StatsComponentCommand.updateStats => typeof(NullStruct),
            StatsComponentCommand.wipeStats => typeof(NullStruct),
            StatsComponentCommand.getLeaderboardGroup => typeof(LeaderboardGroupResponse),
            StatsComponentCommand.getLeaderboardFolderGroup => typeof(LeaderboardFolderGroup),
            StatsComponentCommand.getLeaderboard => typeof(LeaderboardStatValues),
            StatsComponentCommand.getCenteredLeaderboard => typeof(LeaderboardStatValues),
            StatsComponentCommand.getFilteredLeaderboard => typeof(LeaderboardStatValues),
            StatsComponentCommand.getKeyScopesMap => typeof(KeyScopes),
            StatsComponentCommand.getStatsByGroupAsync => typeof(NullStruct),
            StatsComponentCommand.getLeaderboardTreeAsync => typeof(NullStruct),
            StatsComponentCommand.getLeaderboardEntityCount => typeof(EntityCount),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandErrorResponseType(StatsComponentCommand command) => command switch
        {
            StatsComponentCommand.getStatDescs => typeof(NullStruct),
            StatsComponentCommand.getStats => typeof(NullStruct),
            StatsComponentCommand.getStatGroupList => typeof(NullStruct),
            StatsComponentCommand.getStatGroup => typeof(NullStruct),
            StatsComponentCommand.getStatsByGroup => typeof(NullStruct),
            StatsComponentCommand.getDateRange => typeof(NullStruct),
            StatsComponentCommand.getEntityCount => typeof(NullStruct),
            StatsComponentCommand.updateStats => typeof(NullStruct),
            StatsComponentCommand.wipeStats => typeof(NullStruct),
            StatsComponentCommand.getLeaderboardGroup => typeof(NullStruct),
            StatsComponentCommand.getLeaderboardFolderGroup => typeof(NullStruct),
            StatsComponentCommand.getLeaderboard => typeof(NullStruct),
            StatsComponentCommand.getCenteredLeaderboard => typeof(NullStruct),
            StatsComponentCommand.getFilteredLeaderboard => typeof(NullStruct),
            StatsComponentCommand.getKeyScopesMap => typeof(NullStruct),
            StatsComponentCommand.getStatsByGroupAsync => typeof(NullStruct),
            StatsComponentCommand.getLeaderboardTreeAsync => typeof(NullStruct),
            StatsComponentCommand.getLeaderboardEntityCount => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetNotificationType(StatsComponentNotification notification) => notification switch
        {
            StatsComponentNotification.GetStatsAsyncNotification => typeof(KeyScopedStatValues),
            StatsComponentNotification.GetLeaderboardTreeNotification => typeof(LeaderboardTreeNode),
            _ => typeof(NullStruct)
        };
        
        public enum StatsComponentCommand : ushort
        {
            getStatDescs = 1,
            getStats = 2,
            getStatGroupList = 3,
            getStatGroup = 4,
            getStatsByGroup = 5,
            getDateRange = 6,
            getEntityCount = 7,
            updateStats = 8,
            wipeStats = 9,
            getLeaderboardGroup = 10,
            getLeaderboardFolderGroup = 11,
            getLeaderboard = 12,
            getCenteredLeaderboard = 13,
            getFilteredLeaderboard = 14,
            getKeyScopesMap = 15,
            getStatsByGroupAsync = 16,
            getLeaderboardTreeAsync = 17,
            getLeaderboardEntityCount = 18,
        }
        
        public enum StatsComponentNotification : ushort
        {
            GetStatsAsyncNotification = 50,
            GetLeaderboardTreeNotification = 51,
        }
        
    }
}
