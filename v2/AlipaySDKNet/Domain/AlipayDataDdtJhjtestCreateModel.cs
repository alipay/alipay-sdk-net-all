using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDdtJhjtestCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDdtJhjtestCreateModel : AopObject
    {
        /// <summary>
        /// 123456
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 123456
        /// </summary>
        [XmlElement("id_openid")]
        public string IdOpenid { get; set; }

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
        /// aa
        /// </summary>
        [XmlElement("input_d")]
        public string InputD { get; set; }

        /// <summary>
        /// aa
        /// </summary>
        [XmlElement("input_ee")]
        public string InputEe { get; set; }

        /// <summary>
        /// aa
        /// </summary>
        [XmlElement("map_a_openid")]
        public string MapAOpenid { get; set; }
    }
}
