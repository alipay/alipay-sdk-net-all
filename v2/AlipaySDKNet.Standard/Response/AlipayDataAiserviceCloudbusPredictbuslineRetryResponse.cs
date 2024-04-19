using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusPredictbuslineRetryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusPredictbuslineRetryResponse : AopResponse
    {
        /// <summary>
        /// 预测任务提交返回
        /// </summary>
        [XmlElement("result")]
        public CloudbusRetryPredictItem Result { get; set; }
    }
}
