using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialBaseQuestInstanceSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseQuestInstanceSubmitModel : AopObject
    {
        /// <summary>
        /// 小目标实例ID
        /// </summary>
        [XmlElement("instance_id")]
        public string InstanceId { get; set; }

        /// <summary>
        /// 调用方标识
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
