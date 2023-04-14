using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenApidefaultparamQueryResponse.
    /// </summary>
    public class AlipayOpenApidefaultparamQueryResponse : AopResponse
    {
        /// <summary>
        /// 某个接口的默认入参
        /// </summary>
        [XmlElement("param")]
        public string Param { get; set; }
    }
}
