using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossProdQingyongtestQueryResponse.
    /// </summary>
    public class AlipayBossProdQingyongtestQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否调用成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("test_chucan")]
        public string TestChucan { get; set; }
    }
}
