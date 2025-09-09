using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DisplaySetting Data Structure.
    /// </summary>
    [Serializable]
    public class DisplaySetting : AopObject
    {
        /// <summary>
        /// 从枚举中选一个传入
        /// </summary>
        [XmlElement("color")]
        public string Color { get; set; }

        /// <summary>
        /// 不填则c端展示时无活动规则文案
        /// </summary>
        [XmlElement("display_text")]
        public string DisplayText { get; set; }

        /// <summary>
        /// 必填，c端展示时的标题
        /// </summary>
        [XmlElement("main_tail")]
        public string MainTail { get; set; }
    }
}
