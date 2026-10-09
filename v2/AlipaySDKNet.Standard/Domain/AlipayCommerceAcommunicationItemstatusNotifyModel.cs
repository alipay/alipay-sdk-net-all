using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationItemstatusNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationItemstatusNotifyModel : AopObject
    {
        /// <summary>
        /// 商品状态操作类型，1/上架，2/下架
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 支付宝与机构之间的商品id映射码，需要包含关键信息：省份-运营商-面额
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }
    }
}
