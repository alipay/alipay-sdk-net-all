using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudFundWalletOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudFundWalletOrderQueryModel : AopObject
    {
        /// <summary>
        /// 单据号，支持充值、充退和提现的单号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 业务类型【枚举值】 核销: PAYMENT DEPOSIT — 充值； DEPOSIT_BACK — 退款； WITHDRAW — 提现；
        /// </summary>
        [XmlElement("bill_type")]
        public string BillType { get; set; }

        /// <summary>
        /// 钱包id
        /// </summary>
        [XmlElement("user_wallet_id")]
        public string UserWalletId { get; set; }
    }
}
