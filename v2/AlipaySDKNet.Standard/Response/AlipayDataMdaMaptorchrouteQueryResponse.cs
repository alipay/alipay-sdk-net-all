using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataMdaMaptorchrouteQueryResponse.
    /// </summary>
    public class AlipayDataMdaMaptorchrouteQueryResponse : AopResponse
    {
        /// <summary>
        /// 火炬传递路线
        /// </summary>
        [XmlElement("torch_path")]
        public string TorchPath { get; set; }
    }
}
