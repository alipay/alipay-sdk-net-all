using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdTemplateSyncResponse.
    /// </summary>
    public class AlipaySecurityProdTemplateSyncResponse : AopResponse
    {
        /// <summary>
        /// 模板模板编码
        /// </summary>
        [XmlElement("tgt_template_code")]
        public string TgtTemplateCode { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [XmlElement("version_no")]
        public string VersionNo { get; set; }
    }
}
