using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoAgentBehaviorQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoAgentBehaviorQueryModel : AopObject
    {
        /// <summary>
        /// 商户自定义的用户Id。
        /// </summary>
        [XmlElement("custom_id")]
        public string CustomId { get; set; }

        /// <summary>
        /// 智能体实例id
        /// </summary>
        [XmlElement("instance_id")]
        public string InstanceId { get; set; }
    }
}
