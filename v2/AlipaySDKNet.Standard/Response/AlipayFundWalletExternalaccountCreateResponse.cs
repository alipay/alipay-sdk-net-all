using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundWalletExternalaccountCreateResponse.
    /// </summary>
    public class AlipayFundWalletExternalaccountCreateResponse : AopResponse
    {
        /// <summary>
        /// 钱包外部账户ID
        /// </summary>
        [XmlElement("external_account_no")]
        public string ExternalAccountNo { get; set; }

        /// <summary>
        /// 钱包ID
        /// </summary>
        [XmlElement("user_wallet_id")]
        public string UserWalletId { get; set; }
    }
}
