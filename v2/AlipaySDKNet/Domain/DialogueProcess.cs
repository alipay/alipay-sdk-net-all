using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DialogueProcess Data Structure.
    /// </summary>
    [Serializable]
    public class DialogueProcess : AopObject
    {
        /// <summary>
        /// 角色
        /// </summary>
        [XmlElement("actor")]
        public string Actor { get; set; }

        /// <summary>
        /// 发言内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 发言时间
        /// </summary>
        [XmlElement("time")]
        public string Time { get; set; }

        /// <summary>
        /// 内容类型 取值与含义如下： TEXT:文本 FILE:文件
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
