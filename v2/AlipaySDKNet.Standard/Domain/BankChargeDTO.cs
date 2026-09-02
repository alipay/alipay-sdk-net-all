using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BankChargeDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BankChargeDTO : AopObject
    {
        /// <summary>
        /// 境外手续费金额（外币计价）
        /// </summary>
        [XmlElement("bank_feecharge_amount")]
        public TuitionMoneyDTO BankFeechargeAmount { get; set; }

        /// <summary>
        /// 用户是否可自主选择是否承担境外手续费
        /// </summary>
        [XmlElement("bank_feecharge_selectable")]
        public bool BankFeechargeSelectable { get; set; }

        /// <summary>
        /// 该账号是否有境外手续费
        /// </summary>
        [XmlElement("bank_feecharge_type")]
        public bool BankFeechargeType { get; set; }
    }
}
