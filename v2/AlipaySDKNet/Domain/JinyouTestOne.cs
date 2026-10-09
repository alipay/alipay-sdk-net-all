using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JinyouTestOne Data Structure.
    /// </summary>
    [Serializable]
    public class JinyouTestOne : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("o_1_n")]
        public string O1N { get; set; }

        /// <summary>
        /// o_2_y
        /// </summary>
        [XmlElement("o_2_openid")]
        public string O2Openid { get; set; }

        /// <summary>
        /// o_2_y
        /// </summary>
        [XmlElement("o_2_y")]
        public string O2Y { get; set; }

        /// <summary>
        /// o_3_y
        /// </summary>
        [XmlElement("o_3_openid")]
        public string O3Openid { get; set; }

        /// <summary>
        /// o_3_y
        /// </summary>
        [XmlElement("o_3_y")]
        public long O3Y { get; set; }
    }
}
