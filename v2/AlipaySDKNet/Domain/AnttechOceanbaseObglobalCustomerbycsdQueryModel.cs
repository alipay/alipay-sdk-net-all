using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalCustomerbycsdQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalCustomerbycsdQueryModel : AopObject
    {
        /// <summary>
        /// 请求参数
        /// </summary>
        [XmlElement("query_customer_by_csd_work_no_request")]
        public QueryCustomerByCsdWorkNoReq QueryCustomerByCsdWorkNoRequest { get; set; }
    }
}
