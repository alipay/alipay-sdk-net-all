using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BillRepayRequest Data Structure.
    /// </summary>
    [Serializable]
    public class BillRepayRequest : AopObject
    {
        /// <summary>
        /// 还款金额
        /// </summary>
        [XmlElement("repay_amt")]
        public MultiCurrencyMoneyVO RepayAmt { get; set; }
    }
}
