using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppTestGrayCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppTestGrayCreateModel : AopObject
    {
        /// <summary>
        /// a
        /// </summary>
        [XmlElement("a")]
        public string A { get; set; }

        /// <summary>
        /// 生
        /// </summary>
        [XmlElement("b")]
        public string B { get; set; }

        /// <summary>
        /// b1
        /// </summary>
        [XmlElement("body")]
        public string Body { get; set; }

        /// <summary>
        /// body
        /// </summary>
        [XmlElement("body_1")]
        public string Body1 { get; set; }

        /// <summary>
        /// c1
        /// </summary>
        [XmlElement("c")]
        public string C { get; set; }

        /// <summary>
        /// 复杂参数
        /// </summary>
        [XmlElement("complex_param")]
        public OpenidComplex ComplexParam { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("oid")]
        public string Oid { get; set; }

        /// <summary>
        /// xx
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
