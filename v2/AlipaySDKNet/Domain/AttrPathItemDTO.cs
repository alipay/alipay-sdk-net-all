using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AttrPathItemDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AttrPathItemDTO : AopObject
    {
        /// <summary>
        /// 编码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 真实名称
        /// </summary>
        [XmlElement("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 展示名称
        /// </summary>
        [XmlElement("view_name")]
        public string ViewName { get; set; }
    }
}
