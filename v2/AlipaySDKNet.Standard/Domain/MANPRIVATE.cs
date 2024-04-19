using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MANPRIVATE Data Structure.
    /// </summary>
    [Serializable]
    public class MANPRIVATE : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("ss")]
        public string Ss { get; set; }
    }
}
