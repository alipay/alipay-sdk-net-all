using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsWalletAutodepositstatusGetResponse.
    /// </summary>
    public class AlipayCommerceLogisticsWalletAutodepositstatusGetResponse : AopResponse
    {
        /// <summary>
        /// 钱包自动充值开通状态 
        /// </summary>
        [XmlElement("auto_deposit_status")]
        public string AutoDepositStatus { get; set; }

        /// <summary>
        /// 用户操作时间
        /// </summary>
        [XmlElement("user_operation_time")]
        public string UserOperationTime { get; set; }

        /// <summary>
        /// 支付宝钱包唯一ID
        /// </summary>
        [XmlElement("user_wallet_id")]
        public string UserWalletId { get; set; }

        /// <summary>
        /// 钱包归属主体ID
        /// </summary>
        [XmlElement("wallet_partner_id")]
        public string WalletPartnerId { get; set; }
    }
}
