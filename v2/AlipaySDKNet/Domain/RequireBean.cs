using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RequireBean Data Structure.
    /// </summary>
    [Serializable]
    public class RequireBean : AopObject
    {
        /// <summary>
        /// 提示内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 是否开启必填
        /// </summary>
        [XmlElement("valid")]
        public bool Valid { get; set; }
    }
}
