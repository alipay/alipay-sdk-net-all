using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataMdaMiniappsaftyQueryResponse.
    /// </summary>
    public class AlipayDataMdaMiniappsaftyQueryResponse : AopResponse
    {
        /// <summary>
        /// 今日拦截量
        /// </summary>
        [XmlElement("intercept_cnt")]
        public long InterceptCnt { get; set; }

        /// <summary>
        /// 当前拦截率
        /// </summary>
        [XmlElement("intercept_ratio")]
        public long InterceptRatio { get; set; }

        /// <summary>
        /// 拦截趋势
        /// </summary>
        [XmlElement("intercept_trend")]
        public string InterceptTrend { get; set; }

        /// <summary>
        /// 今日请求量
        /// </summary>
        [XmlElement("request_cnt")]
        public long RequestCnt { get; set; }
    }
}
