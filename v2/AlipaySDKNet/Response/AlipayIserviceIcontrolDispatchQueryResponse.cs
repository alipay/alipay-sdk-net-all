using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIcontrolDispatchQueryResponse.
    /// </summary>
    public class AlipayIserviceIcontrolDispatchQueryResponse : AopResponse
    {
        /// <summary>
        /// 热线技能组ID
        /// </summary>
        [XmlElement("skill_group_id")]
        public string SkillGroupId { get; set; }
    }
}
