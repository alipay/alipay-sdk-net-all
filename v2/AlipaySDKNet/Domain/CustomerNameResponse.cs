using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CustomerNameResponse Data Structure.
    /// </summary>
    [Serializable]
    public class CustomerNameResponse : AopObject
    {
        /// <summary>
        /// 常用名
        /// </summary>
        [XmlElement("customer_short_name")]
        public string CustomerShortName { get; set; }

        /// <summary>
        /// 客户名称
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }
    }
}
