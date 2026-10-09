using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdTemplateVersionCopyResponse.
    /// </summary>
    public class AlipaySecurityProdTemplateVersionCopyResponse : AopResponse
    {
        /// <summary>
        /// 版本拷贝结果
        /// </summary>
        [XmlElement("copy_result")]
        public bool CopyResult { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [XmlElement("version_no")]
        public string VersionNo { get; set; }
    }
}
