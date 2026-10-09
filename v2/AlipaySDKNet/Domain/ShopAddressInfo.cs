using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopAddressInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopAddressInfo : AopObject
    {
        /// <summary>
        /// 精度类型，支付宝定义code
        /// </summary>
        [XmlElement("accuracy_type")]
        public string AccuracyType { get; set; }

        /// <summary>
        /// 地址详情
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 国家
        /// </summary>
        [XmlElement("country")]
        public string Country { get; set; }

        /// <summary>
        /// 区
        /// </summary>
        [XmlElement("county")]
        public string County { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 街道
        /// </summary>
        [XmlElement("town")]
        public string Town { get; set; }
    }
}
