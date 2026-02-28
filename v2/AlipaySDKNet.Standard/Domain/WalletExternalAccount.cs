using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WalletExternalAccount Data Structure.
    /// </summary>
    [Serializable]
    public class WalletExternalAccount : AopObject
    {
        /// <summary>
        /// 外部账户id
        /// </summary>
        [XmlElement("external_account_no")]
        public string ExternalAccountNo { get; set; }

        /// <summary>
        /// 外部账户类型
        /// </summary>
        [XmlElement("external_account_type")]
        public string ExternalAccountType { get; set; }

        /// <summary>
        /// 状态: 成功为E 删除为D
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
