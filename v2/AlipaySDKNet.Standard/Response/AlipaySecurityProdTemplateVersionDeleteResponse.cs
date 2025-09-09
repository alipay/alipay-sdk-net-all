using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdTemplateVersionDeleteResponse.
    /// </summary>
    public class AlipaySecurityProdTemplateVersionDeleteResponse : AopResponse
    {
        /// <summary>
        /// 删除结果
        /// </summary>
        [XmlElement("delete_result")]
        public bool DeleteResult { get; set; }
    }
}
