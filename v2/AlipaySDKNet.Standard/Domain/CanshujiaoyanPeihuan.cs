using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CanshujiaoyanPeihuan Data Structure.
    /// </summary>
    [Serializable]
    public class CanshujiaoyanPeihuan : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("a")]
        public string A { get; set; }
    }
}
