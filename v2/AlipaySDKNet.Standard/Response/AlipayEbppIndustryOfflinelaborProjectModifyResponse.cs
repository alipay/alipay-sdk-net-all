using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryOfflinelaborProjectModifyResponse.
    /// </summary>
    public class AlipayEbppIndustryOfflinelaborProjectModifyResponse : AopResponse
    {
        /// <summary>
        /// 用户登记认证跳转地址 例如：alipay://XXXXAPPID=XXXXX/XX?XXX  后续商户跳转时，需要在后面拼接outRegisterNo 与callbackUrl参数。  outRegisterNo=${本次登记请求Id}&callbackUrl=${回跳地址} 「前端确认是否需要 base64编码，还是URLEncode就行」
        /// </summary>
        [XmlElement("register_url")]
        public string RegisterUrl { get; set; }
    }
}
