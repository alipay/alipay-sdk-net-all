using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseWalletBalanceGetResponse.
    /// </summary>
    public class AlipayCloudCloudbaseWalletBalanceGetResponse : AopResponse
    {
        /// <summary>
        /// 可用余额(分)
        /// </summary>
        [XmlElement("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 未支付余额(分)
        /// </summary>
        [XmlElement("unpaid_amount")]
        public string UnpaidAmount { get; set; }

        /// <summary>
        /// 钱包余额(分)
        /// </summary>
        [XmlElement("wallet_amount")]
        public string WalletAmount { get; set; }
    }
}
