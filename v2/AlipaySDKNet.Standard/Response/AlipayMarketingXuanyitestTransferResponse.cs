using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingXuanyitestTransferResponse.
    /// </summary>
    public class AlipayMarketingXuanyitestTransferResponse : AopResponse
    {
        /// <summary>
        /// 12
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
    }
}
