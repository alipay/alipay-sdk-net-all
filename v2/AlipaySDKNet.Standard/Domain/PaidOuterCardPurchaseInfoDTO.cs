using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaidOuterCardPurchaseInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PaidOuterCardPurchaseInfoDTO : AopObject
    {
        /// <summary>
        /// 用户购买、升级、降级、续费的操作时间。格式为：yyyy-MM-dd hh:mm:ss
        /// </summary>
        [XmlElement("action_date")]
        public string ActionDate { get; set; }

        /// <summary>
        /// 支付宝交易号，由api: alipay.trade.create 返回
        /// </summary>
        [XmlElement("alipay_trade_no")]
        public string AlipayTradeNo { get; set; }

        /// <summary>
        /// 商户订单号。与创建订单api：alipay.trade.create保持一致
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 用户购买金额。当购买/升级/续费场景必填，单位元，精确到小数点后2位
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 用户操作来源。枚举如下： ALIPAY_TINY_APP(支付宝小程序) SELF_APP(商家APP) OTHER(其他)
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
