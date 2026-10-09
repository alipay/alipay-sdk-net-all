using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdTemplateSaveResponse.
    /// </summary>
    public class AlipaySecurityProdTemplateSaveResponse : AopResponse
    {
        /// <summary>
        /// 模板更新结果
        /// </summary>
        [XmlElement("update_result")]
        public bool UpdateResult { get; set; }
    }
}
