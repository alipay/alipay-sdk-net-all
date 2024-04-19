using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationCreditphoneOrderPrecreateResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationCreditphoneOrderPrecreateResponse : AopResponse
    {
        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [XmlElement("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 用于业务在后续操作中需要使用的业务信息。一期为orderId用于拉起芝麻收银台
        /// </summary>
        [XmlElement("biz_params")]
        public string BizParams { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }
    }
}
