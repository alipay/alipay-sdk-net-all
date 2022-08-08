using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryNucleicremindSubscribeQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryNucleicremindSubscribeQueryResponse : AopResponse
    {
        /// <summary>
        /// 有效时间，单位小时 当订阅状态为已订阅时改字段有值
        /// </summary>
        [XmlElement("effective_hour")]
        public string EffectiveHour { get; set; }

        /// <summary>
        /// 最新一次核酸报告时间，当订阅状态为已订阅时，改字段返回
        /// </summary>
        [XmlElement("result_time")]
        public string ResultTime { get; set; }

        /// <summary>
        /// 1 为已订阅，0 为未订阅，-1 为业务异常需要降级
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
