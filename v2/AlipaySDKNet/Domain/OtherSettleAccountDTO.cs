using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OtherSettleAccountDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OtherSettleAccountDTO : AopObject
    {
        /// <summary>
        /// 真实姓名
        /// </summary>
        [XmlElement("payee_real_name")]
        public string PayeeRealName { get; set; }

        /// <summary>
        /// 该账户需分账的比例（百分比）
        /// </summary>
        [XmlElement("separate_ledger_rate")]
        public string SeparateLedgerRate { get; set; }

        /// <summary>
        /// 需填入支付宝登陆账户
        /// </summary>
        [XmlElement("settle_account")]
        public string SettleAccount { get; set; }
    }
}
