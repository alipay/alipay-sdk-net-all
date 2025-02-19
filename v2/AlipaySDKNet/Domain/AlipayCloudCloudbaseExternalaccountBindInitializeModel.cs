using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseExternalaccountBindInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseExternalaccountBindInitializeModel : AopObject
    {
        /// <summary>
        /// 服务商账号ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 服务商用户账号名称
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 卡类型
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 登录账号
        /// </summary>
        [XmlElement("main_logon_id")]
        public string MainLogonId { get; set; }

        /// <summary>
        /// 钱包ID
        /// </summary>
        [XmlElement("wallet_id")]
        public string WalletId { get; set; }
    }
}
