using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniStatusInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniStatusInfo : AopObject
    {
        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("display_status")]
        public string DisplayStatus { get; set; }

        /// <summary>
        /// 核销状态描述
        /// </summary>
        [XmlElement("display_status_desc")]
        public string DisplayStatusDesc { get; set; }
    }
}
