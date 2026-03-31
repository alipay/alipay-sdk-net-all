using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FortuneEntityDTO Data Structure.
    /// </summary>
    [Serializable]
    public class FortuneEntityDTO : AopObject
    {
        /// <summary>
        /// 详细信息内容
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }

        /// <summary>
        /// 信息类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
