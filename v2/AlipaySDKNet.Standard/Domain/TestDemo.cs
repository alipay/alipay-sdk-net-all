using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TestDemo Data Structure.
    /// </summary>
    [Serializable]
    public class TestDemo : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("a_open_id")]
        public string AOpenId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("a_uid")]
        public string AUid { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlArray("date_a")]
        [XmlArrayItem("date")]
        public List<string> DateA { get; set; }

        /// <summary>
        /// test 当前字段已废弃(test废弃字段测试)
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlArray("price_a")]
        [XmlArrayItem("price")]
        public List<string> PriceA { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlArray("string_a")]
        [XmlArrayItem("string")]
        public List<string> StringA { get; set; }

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
