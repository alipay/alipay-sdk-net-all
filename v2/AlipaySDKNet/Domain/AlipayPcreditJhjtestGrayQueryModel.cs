using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditJhjtestGrayQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditJhjtestGrayQueryModel : AopObject
    {
        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("para")]
        public string Para { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("para_comp")]
        public Apitestjhj ParaComp { get; set; }
    }
}
