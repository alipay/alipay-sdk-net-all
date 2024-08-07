using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudFundWalletConsultResponse.
    /// </summary>
    public class AlipayCloudFundWalletConsultResponse : AopResponse
    {
        /// <summary>
        /// 实际可以提现/销户后退的金额，单位：元
        /// </summary>
        [XmlElement("actual_available_amount")]
        public string ActualAvailableAmount { get; set; }

        /// <summary>
        /// 卡号
        /// </summary>
        [XmlElement("asset_no")]
        public string AssetNo { get; set; }

        /// <summary>
        /// 可用金额，单位元
        /// </summary>
        [XmlElement("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 总金额，单位元
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 钱包id
        /// </summary>
        [XmlElement("user_wallet_id")]
        public string UserWalletId { get; set; }
    }
}
