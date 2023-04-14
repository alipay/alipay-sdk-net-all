using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantMemberwalletWalletQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantMemberwalletWalletQueryModel : AopObject
    {
        /// <summary>
        /// 会员钱包产品ID
        /// </summary>
        [XmlElement("member_wallet_id")]
        public string MemberWalletId { get; set; }

        /// <summary>
        /// 外部用户唯一标识
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }
    }
}
