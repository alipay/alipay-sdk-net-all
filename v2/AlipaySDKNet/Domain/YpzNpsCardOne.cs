using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// YpzNpsCardOne Data Structure.
    /// </summary>
    [Serializable]
    public class YpzNpsCardOne : AopObject
    {
        /// <summary>
        /// 显示状态
        /// </summary>
        [XmlElement("status")]
        public bool Status { get; set; }
    }
}
