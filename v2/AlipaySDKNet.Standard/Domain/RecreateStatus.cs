using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecreateStatus Data Structure.
    /// </summary>
    [Serializable]
    public class RecreateStatus : AopObject
    {
        /// <summary>
        /// 实例创建原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 实例创建来源
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
