using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeCommercialOrderCreateResponse.
    /// </summary>
    public class AlipayTradeCommercialOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 长链，适用于跳转拉起支付宝端；ui_mode= app_schema时返回
        /// </summary>
        [XmlElement("alipay_jump_schema")]
        public string AlipayJumpSchema { get; set; }

        /// <summary>
        /// 短链，适用于生成二维码 ；ui_mode= app_schema时返回
        /// </summary>
        [XmlElement("alipay_schema")]
        public string AlipaySchema { get; set; }

        /// <summary>
        /// 本次支付的收银台地址，可用于302跳转
        /// </summary>
        [XmlElement("checkout_url")]
        public string CheckoutUrl { get; set; }

        /// <summary>
        /// 本次支付的订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 本次支付的二维码链接，有效期2小时
        /// </summary>
        [XmlElement("qr_code")]
        public string QrCode { get; set; }

        /// <summary>
        /// 本次订单的状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
