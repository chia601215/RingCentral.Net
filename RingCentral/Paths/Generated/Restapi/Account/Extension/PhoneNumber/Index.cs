using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.PhoneNumber
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/phone-number";
        }

        public async Task<RingCentral.GetExtensionPhoneNumbersResponse> Get()
        {
            return await rc.Get<RingCentral.GetExtensionPhoneNumbersResponse>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.PhoneNumber.Index PhoneNumber()
        {
            return new Restapi.Account.Extension.PhoneNumber.Index(this);
        }
    }
}