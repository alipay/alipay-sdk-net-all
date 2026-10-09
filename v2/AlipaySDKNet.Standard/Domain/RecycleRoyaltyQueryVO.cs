using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleRoyaltyQueryVO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleRoyaltyQueryVO : AopObject
    {
        /// <summary>
        /// 绑定的门店/店员userId
        /// </summary>
        [XmlElement("bind_role_id")]
        public string BindRoleId { get; set; }

        /// <summary>
        /// 绑定的门店/店员userId
        /// </summary>
        [XmlElement("bind_role_open_id")]
        public string BindRoleOpenId { get; set; }

        /// <summary>
        /// 绑定的角色类型
        /// </summary>
        [XmlElement("bind_role_type")]
        public string BindRoleType { get; set; }

        /// <summary>
        /// 绑定状态
        /// </summary>
        [XmlElement("bind_status")]
        public string BindStatus { get; set; }

        /// <summary>
        /// 绑定的收款钱包
        /// </summary>
        [XmlElement("bind_wallet_id")]
        public string BindWalletId { get; set; }

        /// <summary>
        /// 收款方式
        /// </summary>
        [XmlElement("bind_wallet_type")]
        public string BindWalletType { get; set; }
    }
}
