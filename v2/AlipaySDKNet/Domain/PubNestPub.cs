using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PubNestPub Data Structure.
    /// </summary>
    [Serializable]
    public class PubNestPub : AopObject
    {
        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("comp_indomain")]
        public RegressionInDomian CompIndomain { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("comp_private")]
        public RegressionPrivate CompPrivate { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("complex")]
        public RegressionPublic Complex { get; set; }
    }
}
