using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAipaySubscribeStatusCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAipaySubscribeStatusCheckModel : AopObject
    {
        /// <summary>
        /// 区分智能体平台，本地部署为其他
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 订购计划id
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 客户Id
        /// </summary>
        [XmlElement("uuid")]
        public string Uuid { get; set; }
    }
}
