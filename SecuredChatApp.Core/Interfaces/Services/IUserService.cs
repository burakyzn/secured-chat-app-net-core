using SecuredChatApp.Core.DTOs;

namespace SecuredChatApp.Core.Interfaces.Services
{
    public interface IUserService
    {
        public ResultModel<object> Login(UserLoginRequest request);
        public ResultModel<object> Register(UserRegisterRequest request);
        public ResultModel<object> AddFriend(AddFriendRequest request);
        public ResultModel<object> GetAddFriendRequests(GetAddFriendRequest request);
        public ResultModel<object> AcceptAddFriendRequest(AcceptAddFriendRequest request);
        public ResultModel<object> RejectAddFriendRequest(RejectAddFriendRequest request);
    }
}