using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayAppXuanyitestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayAppXuanyitestQueryModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("o_1_openid")]
        public string O1Openid { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("o_1_y")]
        public string O1Y { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("o_2_n")]
        public string O2N { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("o_3_f")]
        public JinyouTestFive O3F { get; set; }
    }
}
