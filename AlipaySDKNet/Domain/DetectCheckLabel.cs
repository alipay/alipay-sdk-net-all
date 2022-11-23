using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DetectCheckLabel Data Structure.
    /// </summary>
    [Serializable]
    public class DetectCheckLabel : AopObject
    {
        /// <summary>
        /// 分类信息： porn：色情，  terrorism：暴恐， politic：涉政， ad：广告， adlaw：广告法， contraband：违禁， abuse：谩骂， flood：灌水， negtive：涉价值观， other：其他
        /// </summary>
        [XmlElement("label")]
        public string Label { get; set; }

        /// <summary>
        /// 一级标签分值
        /// </summary>
        [XmlElement("rate")]
        public string Rate { get; set; }

        /// <summary>
        /// 子分类信息，可能包含多个
        /// </summary>
        [XmlArray("sub_check_labels")]
        [XmlArrayItem("sub_check_label")]
        public List<SubCheckLabel> SubCheckLabels { get; set; }
    }
}
