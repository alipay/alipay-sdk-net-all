using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinancePfPaymentQueryResponse.
    /// </summary>
    public class AnttechBlockchainFinancePfPaymentQueryResponse : AopResponse
    {
        /// <summary>
        /// 入账状态
        /// </summary>
        [XmlElement("account_in_status")]
        public string AccountInStatus { get; set; }

        /// <summary>
        /// 个性化参数
        /// </summary>
        [XmlElement("parm")]
        public string Parm { get; set; }
    }
}
