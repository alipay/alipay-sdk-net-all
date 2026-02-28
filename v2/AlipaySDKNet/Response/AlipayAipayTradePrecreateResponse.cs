using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAipayTradePrecreateResponse.
    /// </summary>
    public class AlipayAipayTradePrecreateResponse : AopResponse
    {
        /// <summary>
        /// 商户外部订单号。 与入参一致
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 支付页地址 用户点击后可跳转至支付页面
        /// </summary>
        [XmlElement("pay_url")]
        public string PayUrl { get; set; }

        /// <summary>
        /// 支付页对应二维码图片地址。 用户扫码可跳转至支付页
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }
    }
}
