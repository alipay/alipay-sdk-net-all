using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalCustomerbyownerQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalCustomerbyownerQueryModel : AopObject
    {
        /// <summary>
        /// 请求参数
        /// </summary>
        [XmlElement("query_customer_by_bd_work_no_request")]
        public QueryCustomerByBdWorkNoRequest QueryCustomerByBdWorkNoRequest { get; set; }
    }
}
