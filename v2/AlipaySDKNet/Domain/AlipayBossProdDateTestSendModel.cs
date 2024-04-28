using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdDateTestSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdDateTestSendModel : AopObject
    {
        /// <summary>
        /// test
        /// </summary>
        [XmlElement("a_open_id")]
        public string AOpenId { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("b_open_id")]
        public string BOpenId { get; set; }

        /// <summary>
        /// test修改文档
        /// </summary>
        [XmlElement("test_a")]
        public string TestA { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("test_b")]
        public string TestB { get; set; }
    }
}
