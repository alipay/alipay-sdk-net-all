using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PriNestOther Data Structure.
    /// </summary>
    [Serializable]
    public class PriNestOther : AopObject
    {
        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("com_indomain")]
        public RegressionInDomian ComIndomain { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("com_private")]
        public RegressionPrivate ComPrivate { get; set; }

        /// <summary>
        /// 111
        /// </summary>
        [XmlElement("com_pub")]
        public RegressionPublic ComPub { get; set; }
    }
}
