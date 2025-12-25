using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HmProductInfo Data Structure.
    /// </summary>
    [Serializable]
    public class HmProductInfo : AopObject
    {
        /// <summary>
        /// 商品服务单价，单位：分
        /// </summary>
        [XmlElement("product_amount")]
        public long ProductAmount { get; set; }

        /// <summary>
        /// 商品编码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 商品服务数量
        /// </summary>
        [XmlElement("product_count")]
        public string ProductCount { get; set; }

        /// <summary>
        /// 商品服务名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }
    }
}
