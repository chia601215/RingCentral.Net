namespace RingCentral
{
    public class GetTokenRequest
    {
        /// <summary>
        /// Phone number linked to an account or extension in E.164 format with or without leading '+' sign
        /// </summary>
        public string username;

        /// <summary>
        /// User's password
        /// </summary>
        public string password;

        /// <summary>
        /// Optional. Extension short number. If company number is specified as a username, and extension is not specified, the server will attempt to authenticate client as main company administrator
        /// </summary>
        public string extension;

        /// <summary>
        /// Grant type
        /// Default: password
        /// Enum: authorization_code, password, refresh_token, client_credentials
        /// </summary>
        public string grant_type;

        /// <summary>
        /// Authorization code
        /// </summary>
        public string code;

        /// <summary>
        /// This is a callback URI which determines where the response is sent. The value of this parameter must exactly match one of the URIs you have provided for your app upon registration
        /// </summary>
        public string redirect_uri;

        /// <summary>
        /// Access token lifetime in seconds
        /// Maximum: 3600
        /// Minimum: 600
        /// Default: 3600
        /// </summary>
        public long? access_token_ttl;

        /// <summary>
        /// Refresh token lifetime in seconds
        /// Maximum: 604800
        /// Default: 604800
        /// </summary>
        public long? refresh_token_ttl;

        /// <summary>
        /// List of API permissions to be used with access token. Can be omitted when requesting all permissions defined during the application registration phase
        /// </summary>
        public string scope;

        /// <summary>
        /// Previously issued refresh token. This is the only formData field used for the Refresh Token Flow.
        /// </summary>
        public string refresh_token;

        /// <summary>
        /// The unique identifier of a client application. If not specified, the previously specified or auto generated value is used by default
        /// </summary>
        public string endpoint_id;
    }
}