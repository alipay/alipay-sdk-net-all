using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalCustomerbyepcertnoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalCustomerbyepcertnoQueryModel : AopObject
    {
        /// <summary>
        /// 查询请求参数
        /// </summary>
        [XmlElement("query_customer_by_ep_cert_no_request")]
        public QueryCustomerByEpCertNoRequest QueryCustomerByEpCertNoRequest { get; set; }
    }
}
