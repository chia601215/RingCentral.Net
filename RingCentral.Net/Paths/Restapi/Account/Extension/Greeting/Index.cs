using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.Greeting
{
    public partial class Index
    {
        public RestClient rc;
        public string greetingId;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent, string greetingId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.greetingId = greetingId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && greetingId != null)
            {
                return $"{parent.Path()}/greeting/{greetingId}";
            }

            return $"{parent.Path()}/greeting";
        }

        /// <summary>
        /// Operation: Create User Custom Greeting
        /// Http Post /restapi/v1.0/account/{accountId}/extension/{extensionId}/greeting
        /// </summary>
        public async Task<RingCentral.CustomUserGreetingInfo> Post(
            CreateUserCustomGreetingRequest createUserCustomGreetingRequest)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(createUserCustomGreetingRequest);
            return await rc.Post<RingCentral.CustomUserGreetingInfo>(this.Path(false), multipartFormDataContent);
        }

        /// <summary>
        /// Operation: Get Custom Greeting Info
        /// Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/greeting/{greetingId}
        /// </summary>
        public async Task<RingCentral.CustomUserGreetingInfo> Get()
        {
            if (this.greetingId == null)
            {
                throw new System.ArgumentNullException("greetingId");
            }

            return await rc.Get<RingCentral.CustomUserGreetingInfo>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.Greeting.Index Greeting(string greetingId = null)
        {
            return new Restapi.Account.Extension.Greeting.Index(this, greetingId);
        }
    }
}