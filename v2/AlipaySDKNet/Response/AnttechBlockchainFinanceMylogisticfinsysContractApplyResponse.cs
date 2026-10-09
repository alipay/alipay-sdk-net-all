using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceMylogisticfinsysContractApplyResponse.
    /// </summary>
    public class AnttechBlockchainFinanceMylogisticfinsysContractApplyResponse : AopResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }
    }
}
