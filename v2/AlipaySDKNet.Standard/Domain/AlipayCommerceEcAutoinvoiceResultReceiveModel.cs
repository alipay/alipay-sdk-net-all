using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcAutoinvoiceResultReceiveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcAutoinvoiceResultReceiveModel : AopObject
    {
        /// <summary>
        /// 开票场景
        /// </summary>
        [XmlElement("biz_product")]
        public string BizProduct { get; set; }

        /// <summary>
        /// 订单对应的买家uid
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 订单对应的买家用户的支付宝openid
        /// </summary>
        [XmlElement("buyer_open_id")]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// 开票失败错误码，通知开票失败原因，以此判断是否需要重试开票
        /// </summary>
        [XmlElement("fail_code")]
        public string FailCode { get; set; }

        /// <summary>
        /// 开票失败原因
        /// </summary>
        [XmlElement("fail_message")]
        public string FailMessage { get; set; }

        /// <summary>
        /// 开票结果
        /// </summary>
        [XmlElement("invoice_result")]
        public string InvoiceResult { get; set; }

        /// <summary>
        /// 自定义订单号，同一笔订单必须保证唯一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 订单使用支付宝支付时，对应的支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
