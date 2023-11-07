using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingXuanyitestTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingXuanyitestTransferModel : AopObject
    {
        /// <summary>
        /// 测试的基础描述，描述中有test，不会被aku匹配
        /// </summary>
        [XmlArray("test")]
        [XmlArrayItem("string")]
        public List<string> Test { get; set; }

        /// <summary>
        /// 测试复杂类型描述
        /// </summary>
        [XmlArray("test_21")]
        [XmlArrayItem("marketingtest")]
        public List<Marketingtest> Test21 { get; set; }

        /// <summary>
        /// sasasas
        /// </summary>
        [XmlElement("test_22")]
        public Marketingtestt Test22 { get; set; }
    }
}
