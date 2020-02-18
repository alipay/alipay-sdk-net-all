using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingDataDeerInsightQueryResponse.
    /// </summary>
    public class AlipayMarketingDataDeerInsightQueryResponse : AopResponse
    {
        /// <summary>
        /// 凤蝶洞察信息
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 请求是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
