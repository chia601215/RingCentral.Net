namespace RingCentral
{
    public class ListCompanyActiveCallsParameters
    {
        /// <summary>
        /// The direction for the result records. If not specified, both inbound and outbound records are returned. Multiple values are accepted
        /// </summary>
        public string[] direction;

        /// <summary>
        /// View of call records. The same view parameter specified for FSync will be applied for ISync, the view cannot be changed for ISync
        /// Default: Simple
        /// Enum: Simple, Detailed
        /// </summary>
        public string view;

        /// <summary>
        /// Call type of a record. If not specified, all call types are returned. Multiple values are accepted
        /// </summary>
        public string[] type;

        /// <summary>
        /// Call transport type. 'PSTN' specifies that a call leg is initiated from the PSTN network provider; 'VoIP' - from an RC phone. By default this filter is disabled
        /// </summary>
        public string[] transport;

        /// <summary>
        /// Indicates the page number to retrieve. Only positive number values are accepted
        /// Default: 1
        /// </summary>
        public long? page;

        /// <summary>
        /// Indicates the page size (number of items)
        /// Default: 100
        /// </summary>
        public long? perPage;
    }
}