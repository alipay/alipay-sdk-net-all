using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationCreditphoneOrderPrecreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationCreditphoneOrderPrecreateModel : AopObject
    {
        /// <summary>
        /// 支付宝用户ID（小程序授权获取）
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 支付宝用户ID（小程序授权获取）
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 业务发生时间，如2016-07-06 00:00:02 签约超时关单时间依赖这个时间 这个时间会做幂等校验，如果创单幂等，但时间不同会失败
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 信用购机商品信息
        /// </summary>
        [XmlElement("credit_phone_info")]
        public CreditPhoneInfo CreditPhoneInfo { get; set; }

        /// <summary>
        /// 用户在账单页通过该链接可以跳转到小程序的订单详情页
        /// </summary>
        [XmlElement("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 单元是元。即这笔订单的最大扣款金额
        /// </summary>
        [XmlElement("freeze_amount")]
        public string FreezeAmount { get; set; }

        /// <summary>
        /// 外部业务订单号用于幂等返回预创单信息
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 风控参数
        /// </summary>
        [XmlElement("risk_info")]
        public CreditPhoneRiskInfo RiskInfo { get; set; }

        /// <summary>
        /// 交易组件串
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }
    }
}
