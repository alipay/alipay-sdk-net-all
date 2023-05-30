using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TestDemo Data Structure.
    /// </summary>
    [Serializable]
    public class TestDemo : AopObject
    {
        /// <summary>
        /// test 当前字段已废弃(test废弃字段测试)
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// ttes
        /// </summary>
        [XmlElement("string_yingshe")]
        public string StringYingshe { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("string_yingshe_1_open_id")]
        public string StringYingshe1OpenId { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("string_yingshe_2_openid")]
        public string StringYingshe2Openid { get; set; }

        /// <summary>
        /// test 当前字段已废弃(test废弃字段测试)
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
