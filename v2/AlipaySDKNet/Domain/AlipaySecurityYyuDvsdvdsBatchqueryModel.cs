using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityYyuDvsdvdsBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityYyuDvsdvdsBatchqueryModel : AopObject
    {
        /// <summary>
        /// asd
        /// </summary>
        [XmlElement("asd")]
        public PageTemplateParamInfoDTO Asd { get; set; }

        /// <summary>
        /// sadasdas
        /// </summary>
        [XmlElement("asdasda")]
        public bool Asdasda { get; set; }

        /// <summary>
        /// sadf
        /// </summary>
        [XmlElement("asdf")]
        public string Asdf { get; set; }

        /// <summary>
        /// sdfasdf
        /// </summary>
        [XmlElement("sadf")]
        public bool Sadf { get; set; }

        /// <summary>
        /// 312
        /// </summary>
        [XmlElement("yuyu")]
        public bool Yuyu { get; set; }
    }
}
