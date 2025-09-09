using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceComponentcontextQueryResponse.
    /// </summary>
    public class AlipayIserviceComponentcontextQueryResponse : AopResponse
    {
        /// <summary>
        /// 复杂类型，参见具体字段描述
        /// </summary>
        [XmlArray("component_context_response")]
        [XmlArrayItem("component_context_response")]
        public List<ComponentContextResponse> ComponentContextResponse { get; set; }
    }
}
