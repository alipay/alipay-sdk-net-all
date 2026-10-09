using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JinyouTestFour Data Structure.
    /// </summary>
    [Serializable]
    public class JinyouTestFour : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("f_1_openid")]
        public string F1Openid { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("f_1_y")]
        public string F1Y { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("f_2_f")]
        public JinyouTestThree F2F { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("f_3_openid")]
        public string F3Openid { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("f_3_y")]
        public long F3Y { get; set; }
    }
}
