using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Dictionary.FaxCoverPage
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Dictionary.Index parent;

        public Index(Restapi.Dictionary.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/fax-cover-page";
        }

        public async Task<RingCentral.ListFaxCoverPagesResponse> Get()
        {
            return await rc.Get<RingCentral.ListFaxCoverPagesResponse>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Dictionary
{
    public partial class Index
    {
        public Restapi.Dictionary.FaxCoverPage.Index FaxCoverPage()
        {
            return new Restapi.Dictionary.FaxCoverPage.Index(this);
        }
    }
}