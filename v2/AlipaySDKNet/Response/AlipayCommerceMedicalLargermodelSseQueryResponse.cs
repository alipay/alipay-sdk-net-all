using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalLargermodelSseQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalLargermodelSseQueryResponse : AopResponse
    {
        /// <summary>
        /// 流式内容数据
        /// </summary>
        [XmlElement("data")]
        public StreamMessage Data { get; set; }

        /// <summary>
        /// true：业务执行成功
        /// </summary>
        [XmlElement("succes")]
        public bool Succes { get; set; }
    }
}
