using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTravelShopReportCallbackResponse.
    /// </summary>
    public class AlipayOverseasTravelShopReportCallbackResponse : AopResponse
    {
        /// <summary>
        /// 是否需要重试
        /// </summary>
        [XmlElement("need_retry")]
        public bool NeedRetry { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// fail reason
        /// </summary>
        [XmlElement("result_message")]
        public string ResultMessage { get; set; }

        /// <summary>
        /// 结果状态
        /// </summary>
        [XmlElement("result_status")]
        public string ResultStatus { get; set; }
    }
}
