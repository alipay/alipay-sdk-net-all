using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceWithholdrepayorderAgreementSignResponse.
    /// </summary>
    public class AlipayCommerceWithholdrepayorderAgreementSignResponse : AopResponse
    {
        /// <summary>
        /// 用于跳转支付宝页面的信息，POST和GET方法生成内容不同：使用POST方法执行，结果为html form表单，在浏览器渲染即可；使用GET方法会得到支付宝URL，需要打开或重定向到该URL。建议使用POST方式。
        /// </summary>
        [XmlElement("page_redirection_data")]
        public string PageRedirectionData { get; set; }

        /// <summary>
        /// 所生成的签约跳转链接的短链接
        /// </summary>
        [XmlElement("shortened_page_redirection_url")]
        public string ShortenedPageRedirectionUrl { get; set; }
    }
}
