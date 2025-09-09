using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BatchList Data Structure.
    /// </summary>
    [Serializable]
    public class BatchList : AopObject
    {
        /// <summary>
        /// 送礼后效果动作描述，最长3个字
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 批量数量，最大10000
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 送礼后效果描述，最长8个字
        /// </summary>
        [XmlElement("object_being_acted")]
        public string ObjectBeingActed { get; set; }
    }
}
