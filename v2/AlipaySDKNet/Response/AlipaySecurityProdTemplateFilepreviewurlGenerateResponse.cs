using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdTemplateFilepreviewurlGenerateResponse.
    /// </summary>
    public class AlipaySecurityProdTemplateFilepreviewurlGenerateResponse : AopResponse
    {
        /// <summary>
        /// 获取预览地址返回结果
        /// </summary>
        [XmlElement("get_office_preview_url_response")]
        public GetOfficePreviewURLResponse GetOfficePreviewUrlResponse { get; set; }
    }
}
