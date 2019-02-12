using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Notes.Publish
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Notes.Index parent;

        public Index(Restapi.Glip.Notes.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/publish";
        }

        public async Task<RingCentral.GlipNoteInfo> Post()
        {
            return await rc.Post<RingCentral.GlipNoteInfo>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Notes
{
    public partial class Index
    {
        public Restapi.Glip.Notes.Publish.Index Publish()
        {
            return new Restapi.Glip.Notes.Publish.Index(this);
        }
    }
}