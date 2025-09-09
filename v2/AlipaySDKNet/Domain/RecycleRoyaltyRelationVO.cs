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
        /// 绑定角色loginId
        /// </summary>
        [XmlElement("bind_role_login_id")]
        public string BindRoleLoginId { get; set; }

        /// <summary>
        /// 绑定角色openId
        /// </summary>
        [XmlElement("bind_role_open_id")]
        public string BindRoleOpenId { get; set; }

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
        /// 绑定的收款loginId
        /// </summary>
        [XmlElement("bind_wallet_login_id")]
        public string BindWalletLoginId { get; set; }

        /// <summary>
        /// 绑定的收款openId
        /// </summary>
        [XmlElement("bind_wallet_open_id")]
        public string BindWalletOpenId { get; set; }

        /// <summary>
        /// 绑定的支付类型
        /// </summary>
        [XmlElement("bind_wallet_type")]
        public string BindWalletType { get; set; }
    }
}
