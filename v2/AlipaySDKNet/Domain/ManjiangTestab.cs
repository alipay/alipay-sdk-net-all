using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ManjiangTestab Data Structure.
    /// </summary>
    [Serializable]
    public class ManjiangTestab : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("comflex_1")]
        public string Comflex1 { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("tes")]
        public ManjiangTestabc Tes { get; set; }
    }
}
