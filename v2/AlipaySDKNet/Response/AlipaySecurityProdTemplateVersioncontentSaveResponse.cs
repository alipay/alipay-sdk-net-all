using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdTemplateVersioncontentSaveResponse.
    /// </summary>
    public class AlipaySecurityProdTemplateVersioncontentSaveResponse : AopResponse
    {
        /// <summary>
        /// 编辑结果
        /// </summary>
        [XmlElement("save_result")]
        public bool SaveResult { get; set; }
    }
}
