using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceDataJhjtestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceDataJhjtestQueryModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("inner")]
        public string Inner { get; set; }

        /// <summary>
        /// aa
        /// </summary>
        [XmlElement("input_a")]
        public string InputA { get; set; }

        /// <summary>
        /// aa
        /// </summary>
        [XmlElement("input_b")]
        public string InputB { get; set; }

        /// <summary>
        /// aa
        /// </summary>
        [XmlElement("input_c")]
        public string InputC { get; set; }

        /// <summary>
        /// 文档修改测试，主场景input_c_yincang添加展示
        /// </summary>
        [XmlElement("input_c_yincang")]
        public string InputCYincang { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("input_complex_a")]
        public PublicComplex InputComplexA { get; set; }

        /// <summary>
        /// aa
        /// </summary>
        [XmlElement("input_d")]
        public string InputD { get; set; }

        /// <summary>
        /// aa
        /// </summary>
        [XmlElement("input_e")]
        public string InputE { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 文档变更审核通过
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
