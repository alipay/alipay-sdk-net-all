using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIsponetestWzwtestWzwtestPreviewModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIsponetestWzwtestWzwtestPreviewModel : AopObject
    {
        /// <summary>
        /// number_d
        /// </summary>
        [XmlElement("number_d")]
        public long NumberD { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("s")]
        public long S { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("ss")]
        public string Ss { get; set; }
    }
}
