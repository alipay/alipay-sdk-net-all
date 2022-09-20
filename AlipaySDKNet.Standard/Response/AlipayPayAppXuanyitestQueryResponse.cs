using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayAppXuanyitestQueryResponse.
    /// </summary>
    public class AlipayPayAppXuanyitestQueryResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("f_3_f")]
        public JinyouTestFive F3F { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("r_1_openid")]
        public string R1Openid { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("r_1_y")]
        public string R1Y { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("r_2_n")]
        public string R2N { get; set; }
    }
}
