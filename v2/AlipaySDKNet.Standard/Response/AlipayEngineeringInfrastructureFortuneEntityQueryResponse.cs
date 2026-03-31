using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEngineeringInfrastructureFortuneEntityQueryResponse.
    /// </summary>
    public class AlipayEngineeringInfrastructureFortuneEntityQueryResponse : AopResponse
    {
        /// <summary>
        /// 实体详细信息
        /// </summary>
        [XmlElement("content")]
        public FortuneEntityDTO Content { get; set; }
    }
}
