using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.PagingOnlyGroups.BulkAssign
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.PagingOnlyGroups.Index parent;

        public Index(Restapi.Account.PagingOnlyGroups.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/bulk-assign";
        }

        /// <summary>
        /// Operation: Edit Paging Group Users and Devices
        /// Http Post /restapi/v1.0/account/{accountId}/paging-only-groups/{pagingOnlyGroupId}/bulk-assign
        /// </summary>
        public async Task<string> Post(RingCentral.EditPagingGroupRequest editPagingGroupRequest)
        {
            return await rc.Post<string>(this.Path(), editPagingGroupRequest);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.PagingOnlyGroups
{
    public partial class Index
    {
        public Restapi.Account.PagingOnlyGroups.BulkAssign.Index BulkAssign()
        {
            return new Restapi.Account.PagingOnlyGroups.BulkAssign.Index(this);
        }
    }
}