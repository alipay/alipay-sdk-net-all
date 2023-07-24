using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TipInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TipInfo : AopObject
    {
        /// <summary>
        /// 提示内容
        /// </summary>
        [XmlElement("info")]
        public string Info { get; set; }

        /// <summary>
        /// 提示类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
