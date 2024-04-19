using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceSkillgroupFreenumberQueryResponse.
    /// </summary>
    public class AlipayIserviceSkillgroupFreenumberQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回体
        /// </summary>
        [XmlElement("value")]
        public ListAgentAccountStatesFacadeResponse Value { get; set; }
    }
}
