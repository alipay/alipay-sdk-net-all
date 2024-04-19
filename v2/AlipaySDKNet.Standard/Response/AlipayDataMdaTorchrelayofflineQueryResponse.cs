using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataMdaTorchrelayofflineQueryResponse.
    /// </summary>
    public class AlipayDataMdaTorchrelayofflineQueryResponse : AopResponse
    {
        /// <summary>
        /// 火炬传递人次国家TOP5,json字符串
        /// </summary>
        [XmlElement("top_5_country")]
        public string Top5Country { get; set; }

        /// <summary>
        /// 累计火炬传递次数，long类型
        /// </summary>
        [XmlElement("total_pv")]
        public long TotalPv { get; set; }

        /// <summary>
        /// 累计火炬传递人数，long类型
        /// </summary>
        [XmlElement("total_uv")]
        public long TotalUv { get; set; }
    }
}
