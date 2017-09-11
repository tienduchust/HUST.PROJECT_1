
namespace Hust.Models.Share
{
    public class Enums
    {
        public enum ApplicationTypes
        {
            JavaScript = 0,
            NativeConfidential = 1
        };

        public enum StatusCode
        {
            Ok = 201,
            Accepted = 202,
            Unauthorized = 401,
            Forbidden = 403,
            Error = 500,
            GatewayTimeout = 503,
            TokenInValid = 190
        };

        public enum FormAction
        {
            /// <summary>
            /// Allow Action Read
            /// </summary>
            Read = 0,
            /// <summary>
            /// Allow Action Write
            /// </summary>
            Write = 1,
            /// <summary>
            /// Allow Action Delete
            /// </summary>
            Delete = 2
        }
    }
}
