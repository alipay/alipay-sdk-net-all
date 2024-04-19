using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WalletUseRule Data Structure.
    /// </summary>
    [Serializable]
    public class WalletUseRule : AopObject
    {
        /// <summary>
        /// 在钱包核销时，需要指定核销范围，本字段可通过数组的方式传递商户ID指定商户核销的范围
        /// </summary>
        [XmlElement("merchant_rule")]
        public string MerchantRule { get; set; }
    }
}
