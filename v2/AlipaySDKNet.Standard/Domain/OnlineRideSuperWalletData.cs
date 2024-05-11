using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OnlineRideSuperWalletData Data Structure.
    /// </summary>
    [Serializable]
    public class OnlineRideSuperWalletData : AopObject
    {
        /// <summary>
        /// 超级打车卡开通状态,  已开通：opened  未开通：notOpened
        /// </summary>
        [XmlElement("super_wallet_status")]
        public string SuperWalletStatus { get; set; }
    }
}
