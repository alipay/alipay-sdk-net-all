using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DigitalShopInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DigitalShopInfo : AopObject
    {
        /// <summary>
        /// 门店地址
        /// </summary>
        [XmlElement("digital_shop_address")]
        public string DigitalShopAddress { get; set; }

        /// <summary>
        /// 数字化门店id，门店唯一标识
        /// </summary>
        [XmlElement("digital_shop_id")]
        public string DigitalShopId { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("digital_shop_name")]
        public string DigitalShopName { get; set; }
    }
}
