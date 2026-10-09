using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfcenterBanklogtransferCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfcenterBanklogtransferCreateModel : AopObject
    {
        /// <summary>
        /// 银行流水转账form
        /// </summary>
        [XmlElement("bank_log_transfer_form_new")]
        public BankLogTransferFormNew BankLogTransferFormNew { get; set; }
    }
}
