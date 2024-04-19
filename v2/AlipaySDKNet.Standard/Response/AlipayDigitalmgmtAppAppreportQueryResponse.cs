using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalmgmtAppAppreportQueryResponse.
    /// </summary>
    public class AlipayDigitalmgmtAppAppreportQueryResponse : AopResponse
    {
        /// <summary>
        /// 检测结果
        /// </summary>
        [XmlElement("apmobile_app_detect_result_dto")]
        public ApmobileAppDetectResultDTO ApmobileAppDetectResultDto { get; set; }
    }
}
