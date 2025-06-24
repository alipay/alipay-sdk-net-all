using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIsriskQualitycontrolSubmitResponse.
    /// </summary>
    public class AlipayIserviceIsriskQualitycontrolSubmitResponse : AopResponse
    {
        /// <summary>
        /// 唯一的结果id，用于查询结果
        /// </summary>
        [XmlElement("qc_detect_result_id")]
        public string QcDetectResultId { get; set; }

        /// <summary>
        /// 质检返回信息
        /// </summary>
        [XmlElement("qc_message")]
        public string QcMessage { get; set; }

        /// <summary>
        /// 直接结果
        /// </summary>
        [XmlElement("qc_result")]
        public string QcResult { get; set; }
    }
}
