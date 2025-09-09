using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JoinPanelInfo Data Structure.
    /// </summary>
    [Serializable]
    public class JoinPanelInfo : AopObject
    {
        /// <summary>
        /// 按钮文本
        /// </summary>
        [XmlElement("button_text")]
        public string ButtonText { get; set; }

        /// <summary>
        /// 颜色
        /// </summary>
        [XmlElement("color")]
        public string Color { get; set; }

        /// <summary>
        /// 额外文本
        /// </summary>
        [XmlElement("extra_text")]
        public string ExtraText { get; set; }

        /// <summary>
        /// 选边
        /// </summary>
        [XmlArray("side")]
        [XmlArrayItem("string")]
        public List<string> Side { get; set; }
    }
}
