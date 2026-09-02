using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechMorseMarketingIdcardQualityCheckResponse.
    /// </summary>
    public class AnttechMorseMarketingIdcardQualityCheckResponse : AopResponse
    {
        /// <summary>
        /// 业务流水号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 质检结果
        /// </summary>
        [XmlElement("check_result")]
        public string CheckResult { get; set; }

        /// <summary>
        /// 是否允许降级处理。取值true时表示当前请求采用降级模式，取值false时表示采用正常模式
        /// </summary>
        [XmlElement("fallback")]
        public bool Fallback { get; set; }

        /// <summary>
        /// 质检是否通过（降级放行时为 true）
        /// </summary>
        [XmlElement("passed")]
        public bool Passed { get; set; }

        /// <summary>
        /// 用户可见原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }
    }
}
