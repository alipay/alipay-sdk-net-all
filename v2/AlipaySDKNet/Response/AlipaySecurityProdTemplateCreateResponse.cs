using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdTemplateCreateResponse.
    /// </summary>
    public class AlipaySecurityProdTemplateCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建完成后返回模板编码
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [XmlElement("version_no")]
        public string VersionNo { get; set; }
    }
}
