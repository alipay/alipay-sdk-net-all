using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportOilproductInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportOilproductInfoQueryModel : AopObject
    {
        /// <summary>
        /// 来源
        /// </summary>
        [XmlElement("agent")]
        public string Agent { get; set; }

        /// <summary>
        /// 扩展字段，json格式字符串
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 油站门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
