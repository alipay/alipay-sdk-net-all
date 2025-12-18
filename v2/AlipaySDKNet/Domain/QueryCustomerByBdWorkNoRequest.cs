using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QueryCustomerByBdWorkNoRequest Data Structure.
    /// </summary>
    [Serializable]
    public class QueryCustomerByBdWorkNoRequest : AopObject
    {
        /// <summary>
        /// bd工号
        /// </summary>
        [XmlElement("bd_work_no")]
        public string BdWorkNo { get; set; }

        /// <summary>
        /// 客户编码
        /// </summary>
        [XmlElement("cid")]
        public string Cid { get; set; }

        /// <summary>
        /// 客户名称
        /// </summary>
        [XmlElement("customer_name")]
        public string CustomerName { get; set; }
    }
}
