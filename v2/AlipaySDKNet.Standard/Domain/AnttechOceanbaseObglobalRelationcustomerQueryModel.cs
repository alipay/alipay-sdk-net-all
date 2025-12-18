using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalRelationcustomerQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalRelationcustomerQueryModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("query_customer_and_leads_by_uid_request")]
        [XmlArrayItem("query_customer_and_leads_by_uid_request")]
        public List<QueryCustomerAndLeadsByUidRequest> QueryCustomerAndLeadsByUidRequest { get; set; }
    }
}
