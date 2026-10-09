using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSearchBoxModifyResponse.
    /// </summary>
    public class AlipayOpenSearchBoxModifyResponse : AopResponse
    {
        /// <summary>
        /// 模块配置ID
        /// </summary>
        [XmlElement("module_id")]
        public string ModuleId { get; set; }
    }
}
