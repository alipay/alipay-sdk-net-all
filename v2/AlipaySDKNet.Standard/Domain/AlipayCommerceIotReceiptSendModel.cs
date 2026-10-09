using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotReceiptSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotReceiptSendModel : AopObject
    {
        /// <summary>
        /// 用户支付宝uid，支付渠道为alipay时必填
        /// </summary>
        [XmlElement("alipay_uid")]
        public string AlipayUid { get; set; }

        /// <summary>
        /// 业务appid，需要是同源appid。即同一个pid下的appid
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 电子小票详情信息
        /// </summary>
        [XmlElement("biz_data")]
        public ReceiptBizData BizData { get; set; }

        /// <summary>
        /// 机具身份id
        /// </summary>
        [XmlElement("biztid")]
        public string Biztid { get; set; }

        /// <summary>
        /// 支付渠道 alipay=支付宝 wechat=微信 other=其余
        /// </summary>
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }

        /// <summary>
        /// 直联商户填写pid，  pid和smid必填其一
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 间联商户填写smid，pid和smid必填其一
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 接入来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
