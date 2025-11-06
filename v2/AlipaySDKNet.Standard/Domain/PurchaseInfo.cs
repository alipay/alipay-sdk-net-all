using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PurchaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PurchaseInfo : AopObject
    {
        /// <summary>
        /// 扣款账户id
        /// </summary>
        [XmlElement("bind_wallet_id")]
        public string BindWalletId { get; set; }

        /// <summary>
        /// 账户类型
        /// </summary>
        [XmlElement("bind_wallet_type")]
        public string BindWalletType { get; set; }

        /// <summary>
        /// 代扣关联openid
        /// </summary>
        [XmlElement("pay_relation_openid")]
        public string PayRelationOpenid { get; set; }

        /// <summary>
        /// 代扣关联uid
        /// </summary>
        [XmlElement("pay_relation_uid")]
        public string PayRelationUid { get; set; }
    }
}
