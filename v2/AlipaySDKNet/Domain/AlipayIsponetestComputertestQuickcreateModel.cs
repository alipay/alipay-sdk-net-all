using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIsponetestComputertestQuickcreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIsponetestComputertestQuickcreateModel : AopObject
    {
        /// <summary>
        /// 3
        /// </summary>
        [XmlElement("sssss")]
        public long Sssss { get; set; }

        /// <summary>
        /// sss
        /// </summary>
        [XmlElement("xxxtest")]
        public string Xxxtest { get; set; }
    }
}
