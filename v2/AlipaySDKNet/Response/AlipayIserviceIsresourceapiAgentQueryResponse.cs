using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIsresourceapiAgentQueryResponse.
    /// </summary>
    public class AlipayIserviceIsresourceapiAgentQueryResponse : AopResponse
    {
        /// <summary>
        /// 根据号码得出在指定数据内
        /// </summary>
        [XmlElement("exists")]
        public string Exists { get; set; }
    }
}
