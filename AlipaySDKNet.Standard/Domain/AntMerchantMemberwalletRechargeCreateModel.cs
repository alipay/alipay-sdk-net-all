using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantMemberwalletRechargeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantMemberwalletRechargeCreateModel : AopObject
    {
        /// <summary>
        /// 充值权益金（单位：元）
        /// </summary>
        [XmlElement("benefit_amount")]
        public string BenefitAmount { get; set; }

        /// <summary>
        /// 充值权益金有效期 <br>格式：yyyy-MM-dd
        /// </summary>
        [XmlElement("benefit_validate_date")]
        public string BenefitValidateDate { get; set; }

        /// <summary>
        /// 会员钱包产品ID
        /// </summary>
        [XmlElement("member_wallet_id")]
        public string MemberWalletId { get; set; }

        /// <summary>
        /// 外部交易唯一流水号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 充值本金（单位：元）
        /// </summary>
        [XmlElement("principal_amount")]
        public string PrincipalAmount { get; set; }

        /// <summary>
        /// 充值金额有效期 <br>格式：yyyy-MM-dd
        /// </summary>
        [XmlElement("validate_date")]
        public string ValidateDate { get; set; }

        /// <summary>
        /// 会员钱包账户ID
        /// </summary>
        [XmlElement("wallet_id")]
        public string WalletId { get; set; }
    }
}
