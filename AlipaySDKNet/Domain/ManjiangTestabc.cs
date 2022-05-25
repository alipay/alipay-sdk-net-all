using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ManjiangTestabc Data Structure.
    /// </summary>
    [Serializable]
    public class ManjiangTestabc : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("t")]
        public string T { get; set; }
    }
}
