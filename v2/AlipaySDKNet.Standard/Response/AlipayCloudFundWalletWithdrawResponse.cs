using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudFundWalletWithdrawResponse.
    /// </summary>
    public class AlipayCloudFundWalletWithdrawResponse : AopResponse
    {
        /// <summary>
        /// 提现单据号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 钱包id
        /// </summary>
        [XmlElement("user_wallet_id")]
        public string UserWalletId { get; set; }
    }
}
