using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationFlowPriceModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationFlowPriceModifyModel : AopObject
    {
        /// <summary>
        /// 支付宝与机构之间的商品id映射码，需要包含关键信息：省份-运营商-面额
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 商品变更的价格，单位：元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }
    }
}
