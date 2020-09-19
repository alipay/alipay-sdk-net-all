using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeviceProductInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceProductInfo : AopObject
    {
        /// <summary>
        /// 产品id
        /// </summary>
        [XmlElement("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }
    }
}
