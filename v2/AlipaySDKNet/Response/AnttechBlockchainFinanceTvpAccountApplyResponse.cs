using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceTvpAccountApplyResponse.
    /// </summary>
    public class AnttechBlockchainFinanceTvpAccountApplyResponse : AopResponse
    {
        /// <summary>
        /// 账号ID
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 子户开立授权链接
        /// </summary>
        [XmlElement("authorized_link")]
        public string AuthorizedLink { get; set; }
    }
}
