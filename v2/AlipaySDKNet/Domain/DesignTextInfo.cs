using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DesignTextInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DesignTextInfo : AopObject
    {
        /// <summary>
        /// 布局id
        /// </summary>
        [XmlElement("design_id")]
        public string DesignId { get; set; }

        /// <summary>
        /// 文本信息
        /// </summary>
        [XmlElement("text_group")]
        public TextGroup TextGroup { get; set; }
    }
}
