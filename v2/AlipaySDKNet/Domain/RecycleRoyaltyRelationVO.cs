using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleRoyaltyRelationVO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleRoyaltyRelationVO : AopObject
    {
        /// <summary>
        /// 绑定的角色id
        /// </summary>
        [XmlElement("bind_role_id")]
        public string BindRoleId { get; set; }

        /// <summary>
        /// 绑定的角色类型
        /// </summary>
        [XmlElement("bind_role_type")]
        public string BindRoleType { get; set; }

        /// <summary>
        /// 绑定的收款钱包
        /// </summary>
        [XmlElement("bind_wallet_id")]
        public string BindWalletId { get; set; }

        /// <summary>
        /// 绑定的支付类型
        /// </summary>
        [XmlElement("bind_wallet_type")]
        public string BindWalletType { get; set; }
    }
}
