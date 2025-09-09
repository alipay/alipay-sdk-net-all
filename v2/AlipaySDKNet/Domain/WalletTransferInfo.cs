using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WalletTransferInfo Data Structure.
    /// </summary>
    [Serializable]
    public class WalletTransferInfo : AopObject
    {
        /// <summary>
        /// 钱包id
        /// </summary>
        [XmlElement("user_wallet_id")]
        public string UserWalletId { get; set; }
    }
}
