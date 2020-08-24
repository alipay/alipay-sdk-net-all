using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayAppMarketingConsultResponse.
    /// </summary>
    public class AlipayPayAppMarketingConsultResponse : AopResponse
    {
        /// <summary>
        /// 营销图片地址
        /// </summary>
        [XmlElement("image")]
        public string Image { get; set; }

        /// <summary>
        /// 营销联动唯一标识，商户从响应结果获取到此字段后，在后续调支付宝收单接口进行支付时，需将此字段放入扩展参数中透传带入
        /// </summary>
        [XmlElement("pre_pay_token")]
        public string PrePayToken { get; set; }

        /// <summary>
        /// 营销文案文本内容
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
