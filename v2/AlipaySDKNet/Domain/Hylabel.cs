using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Hylabel Data Structure.
    /// </summary>
    [Serializable]
    public class Hylabel : AopObject
    {
        /// <summary>
        /// 行业id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 行业标签名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 概率值
        /// </summary>
        [XmlElement("probabilities")]
        public string Probabilities { get; set; }
    }
}
