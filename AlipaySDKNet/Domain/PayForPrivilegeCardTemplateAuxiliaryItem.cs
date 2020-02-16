using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PayForPrivilegeCardTemplateAuxiliaryItem Data Structure.
    /// </summary>
    [Serializable]
    public class PayForPrivilegeCardTemplateAuxiliaryItem : AopObject
    {
        /// <summary>
        /// 该辅助区域项目的唯一标识
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 该辅助区域项目的展示文字
        /// </summary>
        [XmlElement("label")]
        public string Label { get; set; }

        /// <summary>
        /// 该辅助区域项目的类型，可选值包括 openWeb(跳转), text(文本)
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 该辅助区域项目的跳转链接，当type为openweb的时候必填
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }

        /// <summary>
        /// 该辅助区域项目的文字描述信息，出现在label的右侧，对label的辅助信息展示
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
