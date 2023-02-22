using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpLabelContent Data Structure.
    /// </summary>
    [Serializable]
    public class EpLabelContent : AopObject
    {
        /// <summary>
        /// 标签分类
        /// </summary>
        [XmlElement("label_category")]
        public string LabelCategory { get; set; }

        /// <summary>
        /// 标签解释说明
        /// </summary>
        [XmlElement("label_definition")]
        public string LabelDefinition { get; set; }

        /// <summary>
        /// 标签情感
        /// </summary>
        [XmlElement("label_emotion")]
        public string LabelEmotion { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [XmlElement("label_name")]
        public string LabelName { get; set; }

        /// <summary>
        /// 标签值
        /// </summary>
        [XmlArray("label_value")]
        [XmlArrayItem("string")]
        public List<string> LabelValue { get; set; }
    }
}
