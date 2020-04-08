using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceRiskWarningAddResponse.
    /// </summary>
    public class AnttechBlockchainFinanceRiskWarningAddResponse : AopResponse
    {
        /// <summary>
        /// 提交结果
        /// </summary>
        [XmlElement("submit_result")]
        public string SubmitResult { get; set; }
    }
}
