using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationFlowCommissionSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationFlowCommissionSubmitModel : AopObject
    {
        /// <summary>
        /// 分佣单价，商品理论佣金单价，单位：元
        /// </summary>
        [XmlElement("commission_price")]
        public string CommissionPrice { get; set; }

        /// <summary>
        /// 支付宝分佣比例，枚举: 0:不分佣 0.3 0.4 1 当商品是商业化商品时该值只能为1
        /// </summary>
        [XmlElement("commission_ratio")]
        public string CommissionRatio { get; set; }

        /// <summary>
        /// 支付宝与机构之间的商品id映射码，需要包含关键信息：省份-运营商-面额
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 结算率，结算比例，0.5即50%比例
        /// </summary>
        [XmlElement("settlement_ratio")]
        public string SettlementRatio { get; set; }
    }
}
