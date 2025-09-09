using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceSchemacomplexthirdRainystestQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceSchemacomplexthirdRainystestQueryResponse : AopResponse
    {
        /// <summary>
        /// 用于跳转支付宝页面的信息，POST和GET方法生成内容不同：使用POST方法执行，结果为html form表单，在浏览器渲染即可；使用GET方法会得到支付宝URL，需要打开或重定向到该URL。建议使用POST方式。
        /// </summary>
        [XmlElement("pageRedirectionData")]
        public string PageRedirectionData { get; set; }
    }
}
