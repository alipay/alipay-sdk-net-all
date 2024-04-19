using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApBillAmtOpenApiResponse Data Structure.
    /// </summary>
    [Serializable]
    public class ApBillAmtOpenApiResponse : AopObject
    {
        /// <summary>
        /// 账单号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 分摊金额
        /// </summary>
        [XmlElement("share_amt")]
        public MultiCurrencyMoneyOpenApi ShareAmt { get; set; }
    }
}
