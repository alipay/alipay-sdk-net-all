using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JinyouTestFive Data Structure.
    /// </summary>
    [Serializable]
    public class JinyouTestFive : AopObject
    {
        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("f_1_f")]
        public JinyouTestFour F1F { get; set; }

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
        public string F3Y { get; set; }

        /// <summary>
        /// 3
        /// </summary>
        [XmlElement("f_4_n")]
        public string F4N { get; set; }
    }
}
