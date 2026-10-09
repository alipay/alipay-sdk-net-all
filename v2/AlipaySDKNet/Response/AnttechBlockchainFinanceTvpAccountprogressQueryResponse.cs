using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceTvpAccountprogressQueryResponse.
    /// </summary>
    public class AnttechBlockchainFinanceTvpAccountprogressQueryResponse : AopResponse
    {
        /// <summary>
        /// 账号，开户成功后返回
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 账号开立状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
