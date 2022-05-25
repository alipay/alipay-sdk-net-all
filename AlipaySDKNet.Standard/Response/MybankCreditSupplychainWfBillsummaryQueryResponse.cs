using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSupplychainWfBillsummaryQueryResponse.
    /// </summary>
    public class MybankCreditSupplychainWfBillsummaryQueryResponse : AopResponse
    {
        /// <summary>
        /// 未还金额 出账前：只有本金，不包含利息 出账后及逾期后：包含本金+利息+罚息 （原因：只有出账后才会对账单进行结息）
        /// </summary>
        [XmlElement("balanceamt")]
        public AmountWf Balanceamt { get; set; }

        /// <summary>
        /// 逾期金额
        /// </summary>
        [XmlElement("ovdamt")]
        public AmountWf Ovdamt { get; set; }

        /// <summary>
        /// 账单状态（正常/逾期
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
