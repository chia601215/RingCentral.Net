using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.MessageSync
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
            return $"{parent.Path()}/message-sync";
        }

        public async Task<RingCentral.GetMessageSyncResponse> Get()
        {
            return await rc.Get<RingCentral.GetMessageSyncResponse>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.MessageSync.Index MessageSync()
        {
            return new Restapi.Account.Extension.MessageSync.Index(this);
        }
    }
}