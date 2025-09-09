using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoAgentBehaviorModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoAgentBehaviorModifyModel : AopObject
    {
        /// <summary>
        /// 用户偏好信息
        /// </summary>
        [XmlElement("behavior")]
        public string Behavior { get; set; }

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
