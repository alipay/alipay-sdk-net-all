using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceTvpAccountCloseResponse.
    /// </summary>
    public class AnttechBlockchainFinanceTvpAccountCloseResponse : AopResponse
    {
        /// <summary>
        /// 账号状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
