using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCommonGuidedcodeReceiveResponse.
    /// </summary>
    public class AlipayCommerceCommonGuidedcodeReceiveResponse : AopResponse
    {
        /// <summary>
        /// 具体跳转的端内链接，为创建模板时的appletId
        /// </summary>
        [XmlElement("guided_code")]
        public string GuidedCode { get; set; }

        /// <summary>
        /// 二维码图片
        /// </summary>
        [XmlElement("guided_code_img")]
        public string GuidedCodeImg { get; set; }

        /// <summary>
        /// 支付宝吱口令
        /// </summary>
        [XmlElement("guided_share_code")]
        public string GuidedShareCode { get; set; }

        /// <summary>
        /// 推广短链接
        /// </summary>
        [XmlElement("guided_short_url")]
        public string GuidedShortUrl { get; set; }
    }
}
