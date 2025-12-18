using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenWanxintestaaaQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenWanxintestaaaQueryModel : AopObject
    {
        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("age")]
        public string Age { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("agee")]
        public string Agee { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("demo")]
        public string Demo { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("test")]
        public string Test { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("ty")]
        public string Ty { get; set; }
    }
}
