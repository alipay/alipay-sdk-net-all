using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserConsumeLevelTagDTO Data Structure.
    /// </summary>
    [Serializable]
    public class UserConsumeLevelTagDTO : AopObject
    {
        /// <summary>
        /// 用户消费能力占比
        /// </summary>
        [XmlElement("ratio")]
        public string Ratio { get; set; }

        /// <summary>
        /// 用户消费能力标签值
        /// </summary>
        [XmlElement("tag_value")]
        public string TagValue { get; set; }
    }
}
