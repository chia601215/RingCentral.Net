using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.NumberParser.Parse
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.NumberParser.Index parent;

        public Index(Restapi.NumberParser.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/parse";
        }

        public async Task<RingCentral.ParsePhoneNumberResponse> Post(
            RingCentral.ParsePhoneNumberRequest parsePhoneNumberRequest)
        {
            return await rc.Post<RingCentral.ParsePhoneNumberResponse>(this.Path(), parsePhoneNumberRequest);
        }
    }
}

namespace RingCentral.Paths.Restapi.NumberParser
{
    public partial class Index
    {
        public Restapi.NumberParser.Parse.Index Parse()
        {
            return new Restapi.NumberParser.Parse.Index(this);
        }
    }
}