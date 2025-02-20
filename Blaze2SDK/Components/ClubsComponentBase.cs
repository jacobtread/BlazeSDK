using Blaze2SDK.Blaze.Clubs;
using BlazeCommon;

namespace Blaze2SDK.Components
{
    public static class ClubsComponentBase
    {
        public const ushort Id = 11;
        public const string Name = "ClubsComponent";
        
        public class Server : BlazeComponent<ClubsComponentCommand, ClubsComponentNotification, Blaze2RpcError>
        {
            public Server() : base(ClubsComponentBase.Id, ClubsComponentBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.createClub)]
            public virtual Task<NullStruct> CreateClubAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.getClubs)]
            public virtual Task<NullStruct> GetClubsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.findClubs)]
            public virtual Task<NullStruct> FindClubsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.removeMember)]
            public virtual Task<NullStruct> RemoveMemberAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.sendInvitation)]
            public virtual Task<NullStruct> SendInvitationAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.getInvitations)]
            public virtual Task<NullStruct> GetInvitationsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.revokeInvitation)]
            public virtual Task<NullStruct> RevokeInvitationAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.acceptInvitation)]
            public virtual Task<NullStruct> AcceptInvitationAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.declineInvitation)]
            public virtual Task<NullStruct> DeclineInvitationAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.getMembers)]
            public virtual Task<NullStruct> GetMembersAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.promoteToGM)]
            public virtual Task<NullStruct> PromoteToGMAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.updateClubSettings)]
            public virtual Task<NullStruct> UpdateClubSettingsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.postNews)]
            public virtual Task<NullStruct> PostNewsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.getNews)]
            public virtual Task<NullStruct> GetNewsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.setNewsItemHidden)]
            public virtual Task<NullStruct> SetNewsItemHiddenAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.setMetadata)]
            public virtual Task<NullStruct> SetMetadataAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.getClubsComponentSettings)]
            public virtual Task<NullStruct> GetClubsComponentSettingsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.getClubMembershipForUsers)]
            public virtual Task<NullStruct> GetClubMembershipForUsersAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.sendPetition)]
            public virtual Task<NullStruct> SendPetitionAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.getPetitions)]
            public virtual Task<NullStruct> GetPetitionsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.acceptPetition)]
            public virtual Task<NullStruct> AcceptPetitionAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.declinePetition)]
            public virtual Task<NullStruct> DeclinePetitionAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.revokePetition)]
            public virtual Task<NullStruct> RevokePetitionAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.joinClub)]
            public virtual Task<NullStruct> JoinClubAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.getClubRecordbook)]
            public virtual Task<NullStruct> GetClubRecordbookAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.resetClubRecords)]
            public virtual Task<NullStruct> ResetClubRecordsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.updateMemberOnlineStatus)]
            public virtual Task<NullStruct> UpdateMemberOnlineStatusAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.getClubAwards)]
            public virtual Task<NullStruct> GetClubAwardsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.updateMemberMetadata)]
            public virtual Task<NullStruct> UpdateMemberMetadataAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.findClubsAsync)]
            public virtual Task<NullStruct> FindClubsAsyncAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.listRivals)]
            public virtual Task<NullStruct> ListRivalsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.getClubTickerMessages)]
            public virtual Task<NullStruct> GetClubTickerMessagesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.setClubTickerMessagesSubscription)]
            public virtual Task<NullStruct> SetClubTickerMessagesSubscriptionAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.changeClubStrings)]
            public virtual Task<NullStruct> ChangeClubStringsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.countMessages)]
            public virtual Task<NullStruct> CountMessagesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.getClubBans)]
            public virtual Task<NullStruct> GetClubBansAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.getUserBans)]
            public virtual Task<NullStruct> GetUserBansAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.banMember)]
            public virtual Task<NullStruct> BanMemberAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.unbanMember)]
            public virtual Task<NullStruct> UnbanMemberAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            
            public static Task NotifyFindClubsAsyncNotificationAsync(BlazeServerConnection connection, FindClubsAsyncResult notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(ClubsComponentBase.Id, (ushort)ClubsComponentNotification.FindClubsAsyncNotification, notification, waitUntilFree);
            }
            
            public static Task NotifyNewClubTickerMessageNotificationAsync(BlazeServerConnection connection, ClubTickerMessage notification, bool waitUntilFree = false)
            {
                return connection.NotifyAsync(ClubsComponentBase.Id, (ushort)ClubsComponentNotification.NewClubTickerMessageNotification, notification, waitUntilFree);
            }
            
            public override Type GetCommandRequestType(ClubsComponentCommand command) => ClubsComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(ClubsComponentCommand command) => ClubsComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(ClubsComponentCommand command) => ClubsComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(ClubsComponentNotification notification) => ClubsComponentBase.GetNotificationType(notification);
            
        }
        
        public class Client : BlazeComponent<ClubsComponentCommand, ClubsComponentNotification, Blaze2RpcError>
        {
            public Client() : base(ClubsComponentBase.Id, ClubsComponentBase.Name)
            {
                
            }
            
            public override Type GetCommandRequestType(ClubsComponentCommand command) => ClubsComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(ClubsComponentCommand command) => ClubsComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(ClubsComponentCommand command) => ClubsComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(ClubsComponentNotification notification) => ClubsComponentBase.GetNotificationType(notification);
            
        }
        
        public static Type GetCommandRequestType(ClubsComponentCommand command) => command switch
        {
            ClubsComponentCommand.createClub => typeof(NullStruct),
            ClubsComponentCommand.getClubs => typeof(NullStruct),
            ClubsComponentCommand.findClubs => typeof(NullStruct),
            ClubsComponentCommand.removeMember => typeof(NullStruct),
            ClubsComponentCommand.sendInvitation => typeof(NullStruct),
            ClubsComponentCommand.getInvitations => typeof(NullStruct),
            ClubsComponentCommand.revokeInvitation => typeof(NullStruct),
            ClubsComponentCommand.acceptInvitation => typeof(NullStruct),
            ClubsComponentCommand.declineInvitation => typeof(NullStruct),
            ClubsComponentCommand.getMembers => typeof(NullStruct),
            ClubsComponentCommand.promoteToGM => typeof(NullStruct),
            ClubsComponentCommand.updateClubSettings => typeof(NullStruct),
            ClubsComponentCommand.postNews => typeof(NullStruct),
            ClubsComponentCommand.getNews => typeof(NullStruct),
            ClubsComponentCommand.setNewsItemHidden => typeof(NullStruct),
            ClubsComponentCommand.setMetadata => typeof(NullStruct),
            ClubsComponentCommand.getClubsComponentSettings => typeof(NullStruct),
            ClubsComponentCommand.getClubMembershipForUsers => typeof(NullStruct),
            ClubsComponentCommand.sendPetition => typeof(NullStruct),
            ClubsComponentCommand.getPetitions => typeof(NullStruct),
            ClubsComponentCommand.acceptPetition => typeof(NullStruct),
            ClubsComponentCommand.declinePetition => typeof(NullStruct),
            ClubsComponentCommand.revokePetition => typeof(NullStruct),
            ClubsComponentCommand.joinClub => typeof(NullStruct),
            ClubsComponentCommand.getClubRecordbook => typeof(NullStruct),
            ClubsComponentCommand.resetClubRecords => typeof(NullStruct),
            ClubsComponentCommand.updateMemberOnlineStatus => typeof(NullStruct),
            ClubsComponentCommand.getClubAwards => typeof(NullStruct),
            ClubsComponentCommand.updateMemberMetadata => typeof(NullStruct),
            ClubsComponentCommand.findClubsAsync => typeof(NullStruct),
            ClubsComponentCommand.listRivals => typeof(NullStruct),
            ClubsComponentCommand.getClubTickerMessages => typeof(NullStruct),
            ClubsComponentCommand.setClubTickerMessagesSubscription => typeof(NullStruct),
            ClubsComponentCommand.changeClubStrings => typeof(NullStruct),
            ClubsComponentCommand.countMessages => typeof(NullStruct),
            ClubsComponentCommand.getClubBans => typeof(NullStruct),
            ClubsComponentCommand.getUserBans => typeof(NullStruct),
            ClubsComponentCommand.banMember => typeof(NullStruct),
            ClubsComponentCommand.unbanMember => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandResponseType(ClubsComponentCommand command) => command switch
        {
            ClubsComponentCommand.createClub => typeof(NullStruct),
            ClubsComponentCommand.getClubs => typeof(NullStruct),
            ClubsComponentCommand.findClubs => typeof(NullStruct),
            ClubsComponentCommand.removeMember => typeof(NullStruct),
            ClubsComponentCommand.sendInvitation => typeof(NullStruct),
            ClubsComponentCommand.getInvitations => typeof(NullStruct),
            ClubsComponentCommand.revokeInvitation => typeof(NullStruct),
            ClubsComponentCommand.acceptInvitation => typeof(NullStruct),
            ClubsComponentCommand.declineInvitation => typeof(NullStruct),
            ClubsComponentCommand.getMembers => typeof(NullStruct),
            ClubsComponentCommand.promoteToGM => typeof(NullStruct),
            ClubsComponentCommand.updateClubSettings => typeof(NullStruct),
            ClubsComponentCommand.postNews => typeof(NullStruct),
            ClubsComponentCommand.getNews => typeof(NullStruct),
            ClubsComponentCommand.setNewsItemHidden => typeof(NullStruct),
            ClubsComponentCommand.setMetadata => typeof(NullStruct),
            ClubsComponentCommand.getClubsComponentSettings => typeof(NullStruct),
            ClubsComponentCommand.getClubMembershipForUsers => typeof(NullStruct),
            ClubsComponentCommand.sendPetition => typeof(NullStruct),
            ClubsComponentCommand.getPetitions => typeof(NullStruct),
            ClubsComponentCommand.acceptPetition => typeof(NullStruct),
            ClubsComponentCommand.declinePetition => typeof(NullStruct),
            ClubsComponentCommand.revokePetition => typeof(NullStruct),
            ClubsComponentCommand.joinClub => typeof(NullStruct),
            ClubsComponentCommand.getClubRecordbook => typeof(NullStruct),
            ClubsComponentCommand.resetClubRecords => typeof(NullStruct),
            ClubsComponentCommand.updateMemberOnlineStatus => typeof(NullStruct),
            ClubsComponentCommand.getClubAwards => typeof(NullStruct),
            ClubsComponentCommand.updateMemberMetadata => typeof(NullStruct),
            ClubsComponentCommand.findClubsAsync => typeof(NullStruct),
            ClubsComponentCommand.listRivals => typeof(NullStruct),
            ClubsComponentCommand.getClubTickerMessages => typeof(NullStruct),
            ClubsComponentCommand.setClubTickerMessagesSubscription => typeof(NullStruct),
            ClubsComponentCommand.changeClubStrings => typeof(NullStruct),
            ClubsComponentCommand.countMessages => typeof(NullStruct),
            ClubsComponentCommand.getClubBans => typeof(NullStruct),
            ClubsComponentCommand.getUserBans => typeof(NullStruct),
            ClubsComponentCommand.banMember => typeof(NullStruct),
            ClubsComponentCommand.unbanMember => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandErrorResponseType(ClubsComponentCommand command) => command switch
        {
            ClubsComponentCommand.createClub => typeof(NullStruct),
            ClubsComponentCommand.getClubs => typeof(NullStruct),
            ClubsComponentCommand.findClubs => typeof(NullStruct),
            ClubsComponentCommand.removeMember => typeof(NullStruct),
            ClubsComponentCommand.sendInvitation => typeof(NullStruct),
            ClubsComponentCommand.getInvitations => typeof(NullStruct),
            ClubsComponentCommand.revokeInvitation => typeof(NullStruct),
            ClubsComponentCommand.acceptInvitation => typeof(NullStruct),
            ClubsComponentCommand.declineInvitation => typeof(NullStruct),
            ClubsComponentCommand.getMembers => typeof(NullStruct),
            ClubsComponentCommand.promoteToGM => typeof(NullStruct),
            ClubsComponentCommand.updateClubSettings => typeof(NullStruct),
            ClubsComponentCommand.postNews => typeof(NullStruct),
            ClubsComponentCommand.getNews => typeof(NullStruct),
            ClubsComponentCommand.setNewsItemHidden => typeof(NullStruct),
            ClubsComponentCommand.setMetadata => typeof(NullStruct),
            ClubsComponentCommand.getClubsComponentSettings => typeof(NullStruct),
            ClubsComponentCommand.getClubMembershipForUsers => typeof(NullStruct),
            ClubsComponentCommand.sendPetition => typeof(NullStruct),
            ClubsComponentCommand.getPetitions => typeof(NullStruct),
            ClubsComponentCommand.acceptPetition => typeof(NullStruct),
            ClubsComponentCommand.declinePetition => typeof(NullStruct),
            ClubsComponentCommand.revokePetition => typeof(NullStruct),
            ClubsComponentCommand.joinClub => typeof(NullStruct),
            ClubsComponentCommand.getClubRecordbook => typeof(NullStruct),
            ClubsComponentCommand.resetClubRecords => typeof(NullStruct),
            ClubsComponentCommand.updateMemberOnlineStatus => typeof(NullStruct),
            ClubsComponentCommand.getClubAwards => typeof(NullStruct),
            ClubsComponentCommand.updateMemberMetadata => typeof(NullStruct),
            ClubsComponentCommand.findClubsAsync => typeof(NullStruct),
            ClubsComponentCommand.listRivals => typeof(NullStruct),
            ClubsComponentCommand.getClubTickerMessages => typeof(NullStruct),
            ClubsComponentCommand.setClubTickerMessagesSubscription => typeof(NullStruct),
            ClubsComponentCommand.changeClubStrings => typeof(NullStruct),
            ClubsComponentCommand.countMessages => typeof(NullStruct),
            ClubsComponentCommand.getClubBans => typeof(NullStruct),
            ClubsComponentCommand.getUserBans => typeof(NullStruct),
            ClubsComponentCommand.banMember => typeof(NullStruct),
            ClubsComponentCommand.unbanMember => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetNotificationType(ClubsComponentNotification notification) => notification switch
        {
            ClubsComponentNotification.FindClubsAsyncNotification => typeof(FindClubsAsyncResult),
            ClubsComponentNotification.NewClubTickerMessageNotification => typeof(ClubTickerMessage),
            _ => typeof(NullStruct)
        };
        
        public enum ClubsComponentCommand : ushort
        {
            createClub = 1100,
            getClubs = 1200,
            findClubs = 1300,
            removeMember = 1400,
            sendInvitation = 1500,
            getInvitations = 1600,
            revokeInvitation = 1700,
            acceptInvitation = 1800,
            declineInvitation = 1900,
            getMembers = 2000,
            promoteToGM = 2100,
            updateClubSettings = 2200,
            postNews = 2300,
            getNews = 2400,
            setNewsItemHidden = 2450,
            setMetadata = 2500,
            getClubsComponentSettings = 2600,
            getClubMembershipForUsers = 2700,
            sendPetition = 2800,
            getPetitions = 2900,
            acceptPetition = 3000,
            declinePetition = 3100,
            revokePetition = 3200,
            joinClub = 3300,
            getClubRecordbook = 3400,
            resetClubRecords = 3410,
            updateMemberOnlineStatus = 3500,
            getClubAwards = 3600,
            updateMemberMetadata = 3700,
            findClubsAsync = 3800,
            listRivals = 3900,
            getClubTickerMessages = 4000,
            setClubTickerMessagesSubscription = 4100,
            changeClubStrings = 4200,
            countMessages = 4300,
            getClubBans = 4400,
            getUserBans = 4500,
            banMember = 4600,
            unbanMember = 4700,
        }
        
        public enum ClubsComponentNotification : ushort
        {
            FindClubsAsyncNotification = 14464,
            NewClubTickerMessageNotification = 15464,
        }
        
    }
}
