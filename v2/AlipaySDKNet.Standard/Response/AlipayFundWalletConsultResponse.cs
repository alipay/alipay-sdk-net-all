using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundWalletConsultResponse.
    /// </summary>
    public class AlipayFundWalletConsultResponse : AopResponse
    {
        /// <summary>
        /// 实际可以提现/销户后退的金额，单位：元
        /// </summary>
        [XmlElement("actual_available_amount")]
        public string ActualAvailableAmount { get; set; }

        /// <summary>
        /// 专项账户金额详情
        /// </summary>
        [XmlElement("amount_details")]
        public string AmountDetails { get; set; }

        /// <summary>
        /// 2023122000392001363140394362
        /// </summary>
        [XmlElement("asset_no")]
        public string AssetNo { get; set; }

        /// <summary>
        /// 可用金额，单位：元
        /// </summary>
        [XmlElement("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 错误code
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 钱包id
        /// </summary>
        [XmlElement("user_wallet_id")]
        public string UserWalletId { get; set; }

        /// <summary>
        /// 用户钱包开通状态 I - 申请中 E -生效
        /// </summary>
        [XmlElement("user_wallet_status")]
        public string UserWalletStatus { get; set; }

        /// <summary>
        /// 钱包所属用户的状态 NORMAL - 正常 ABNORMAL - 异常 CLOSED - 已注销
        /// </summary>
        [XmlElement("wallet_owner_status")]
        public string WalletOwnerStatus { get; set; }
    }
}
