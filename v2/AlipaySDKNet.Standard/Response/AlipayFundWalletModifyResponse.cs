using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundWalletModifyResponse.
    /// </summary>
    public class AlipayFundWalletModifyResponse : AopResponse
    {
        /// <summary>
        /// 用户钱包id
        /// </summary>
        [XmlElement("user_wallet_id")]
        public string UserWalletId { get; set; }

        /// <summary>
        /// 钱包名称
        /// </summary>
        [XmlElement("wallet_name")]
        public string WalletName { get; set; }
    }
}
