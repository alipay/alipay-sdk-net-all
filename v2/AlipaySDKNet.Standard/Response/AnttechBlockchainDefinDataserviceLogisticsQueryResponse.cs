using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainDefinDataserviceLogisticsQueryResponse.
    /// </summary>
    public class AnttechBlockchainDefinDataserviceLogisticsQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务结果
        /// </summary>
        [XmlElement("biz_result")]
        public string BizResult { get; set; }
    }
}
