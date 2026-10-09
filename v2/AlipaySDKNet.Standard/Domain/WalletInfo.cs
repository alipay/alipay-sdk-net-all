using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WalletInfo Data Structure.
    /// </summary>
    [Serializable]
    public class WalletInfo : AopObject
    {
        /// <summary>
        /// 用户钱包id
        /// </summary>
        [XmlElement("user_wallet_id")]
        public string UserWalletId { get; set; }

        /// <summary>
        /// 钱包状态
        /// </summary>
        [XmlElement("user_wallet_status")]
        public string UserWalletStatus { get; set; }

        /// <summary>
        /// 钱包模板id
        /// </summary>
        [XmlElement("wallet_template_id")]
        public string WalletTemplateId { get; set; }
    }
}
