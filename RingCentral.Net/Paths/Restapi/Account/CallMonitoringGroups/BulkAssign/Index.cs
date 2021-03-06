using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.CallMonitoringGroups.BulkAssign
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.CallMonitoringGroups.Index parent;

        public Index(Restapi.Account.CallMonitoringGroups.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/bulk-assign";
        }

        /// <summary>
        /// Operation: Edit Call Monitoring Group
        /// Http Post /restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}/bulk-assign
        /// </summary>
        public async Task<string> Post(RingCentral.CallMonitoringBulkAssign callMonitoringBulkAssign)
        {
            return await rc.Post<string>(this.Path(), callMonitoringBulkAssign);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.CallMonitoringGroups
{
    public partial class Index
    {
        public Restapi.Account.CallMonitoringGroups.BulkAssign.Index BulkAssign()
        {
            return new Restapi.Account.CallMonitoringGroups.BulkAssign.Index(this);
        }
    }
}