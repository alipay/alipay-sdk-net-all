using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceAssetRegisterSubmitResponse.
    /// </summary>
    public class AnttechBlockchainFinanceAssetRegisterSubmitResponse : AopResponse
    {
        /// <summary>
        /// 提交结果，根据operate不同而不同。
        /// </summary>
        [XmlElement("submit_result")]
        public string SubmitResult { get; set; }
    }
}
