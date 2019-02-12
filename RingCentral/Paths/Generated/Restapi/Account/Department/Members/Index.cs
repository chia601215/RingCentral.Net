using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Department.Members
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Department.Index parent;

        public Index(Restapi.Account.Department.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/members";
        }

        public async Task<RingCentral.DepartmentMemberList> Get()
        {
            return await rc.Get<RingCentral.DepartmentMemberList>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Department
{
    public partial class Index
    {
        public Restapi.Account.Department.Members.Index Members()
        {
            return new Restapi.Account.Department.Members.Index(this);
        }
    }
}