using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DomainNestOther Data Structure.
    /// </summary>
    [Serializable]
    public class DomainNestOther : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("com_domain")]
        public RegressionInDomian ComDomain { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("com_private")]
        public RegressionPrivate ComPrivate { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("com_public")]
        public RegressionPublic ComPublic { get; set; }
    }
}
