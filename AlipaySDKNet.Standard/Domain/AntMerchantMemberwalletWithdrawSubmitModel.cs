using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantMemberwalletWithdrawSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantMemberwalletWithdrawSubmitModel : AopObject
    {
        /// <summary>
        /// 会员钱包产品ID
        /// </summary>
        [XmlElement("member_wallet_id")]
        public string MemberWalletId { get; set; }

        /// <summary>
        /// 外部业务唯一流水号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 会员钱包账户ID
        /// </summary>
        [XmlElement("wallet_id")]
        public string WalletId { get; set; }

        /// <summary>
        /// 提现金额（单位：元）
        /// </summary>
        [XmlElement("withdraw_amount")]
        public string WithdrawAmount { get; set; }
    }
}
