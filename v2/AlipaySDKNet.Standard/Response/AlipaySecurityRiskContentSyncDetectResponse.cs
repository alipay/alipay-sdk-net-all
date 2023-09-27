using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskContentSyncDetectResponse.
    /// </summary>
    public class AlipaySecurityRiskContentSyncDetectResponse : AopResponse
    {
        /// <summary>
        /// 风险识别标签内容
        /// </summary>
        [XmlElement("detect_check_labels")]
        public DetectCheckLabel DetectCheckLabels { get; set; }

        /// <summary>
        /// 是否计费
        /// </summary>
        [XmlElement("is_meter")]
        public bool IsMeter { get; set; }

        /// <summary>
        /// 是否同步返回
        /// </summary>
        [XmlElement("is_sync")]
        public bool IsSync { get; set; }

        /// <summary>
        /// 计量产品，";"分割
        /// </summary>
        [XmlElement("meter_products")]
        public string MeterProducts { get; set; }

        /// <summary>
        /// 业务请求ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 业务返回结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 返回结果信息
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }

        /// <summary>
        /// 处置建议
        /// </summary>
        [XmlElement("suggestion")]
        public string Suggestion { get; set; }
    }
}
