using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Apitestjhj Data Structure.
    /// </summary>
    [Serializable]
    public class Apitestjhj : AopObject
    {
        /// <summary>
        /// a
        /// </summary>
        [XmlElement("para_a")]
        public string ParaA { get; set; }

        /// <summary>
        /// a
        /// </summary>
        [XmlElement("para_b")]
        public string ParaB { get; set; }

        /// <summary>
        /// aa
        /// </summary>
        [XmlElement("para_c")]
        public string ParaC { get; set; }

        /// <summary>
        /// aa
        /// </summary>
        [XmlElement("para_d")]
        public string ParaD { get; set; }

        /// <summary>
        /// aa
        /// </summary>
        [XmlElement("para_e")]
        public string ParaE { get; set; }
    }
}
