using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantMemberwalletBalanceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantMemberwalletBalanceQueryModel : AopObject
    {
        /// <summary>
        /// 会员钱包产品ID
        /// </summary>
        [XmlElement("member_wallet_id")]
        public string MemberWalletId { get; set; }

        /// <summary>
        /// 会员钱包账户ID
        /// </summary>
        [XmlElement("wallet_id")]
        public string WalletId { get; set; }
    }
}
