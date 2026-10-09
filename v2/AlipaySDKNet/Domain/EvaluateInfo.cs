using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EvaluateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EvaluateInfo : AopObject
    {
        /// <summary>
        /// 评价内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 评价分
        /// </summary>
        [XmlElement("driver_score")]
        public string DriverScore { get; set; }

        /// <summary>
        /// 评价id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
