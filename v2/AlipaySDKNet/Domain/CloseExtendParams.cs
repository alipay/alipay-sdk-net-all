using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CloseExtendParams Data Structure.
    /// </summary>
    [Serializable]
    public class CloseExtendParams : AopObject
    {
        /// <summary>
        /// 标识是否通过其他方式履约
        /// </summary>
        [XmlElement("is_fulfilled")]
        public string IsFulfilled { get; set; }
    }
}
