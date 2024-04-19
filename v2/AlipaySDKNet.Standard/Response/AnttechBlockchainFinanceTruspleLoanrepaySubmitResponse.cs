using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceTruspleLoanrepaySubmitResponse.
    /// </summary>
    public class AnttechBlockchainFinanceTruspleLoanrepaySubmitResponse : AopResponse
    {
        /// <summary>
        /// 结果状态，S表示成功，F表示明确失败，U表示未知异常。一般返回U，调用方可能会重试
        /// </summary>
        [XmlElement("result_status")]
        public string ResultStatus { get; set; }
    }
}
