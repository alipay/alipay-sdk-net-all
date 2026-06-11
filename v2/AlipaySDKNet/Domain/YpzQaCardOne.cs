using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// YpzQaCardOne Data Structure.
    /// </summary>
    [Serializable]
    public class YpzQaCardOne : AopObject
    {
        /// <summary>
        /// 显示状态
        /// </summary>
        [XmlElement("status")]
        public bool Status { get; set; }
    }
}
