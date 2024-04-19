using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeRepaybillBillinConfirmResponse.
    /// </summary>
    public class AlipayTradeRepaybillBillinConfirmResponse : AopResponse
    {
        /// <summary>
        /// 账单累计已入账金额,精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("bill_amount")]
        public string BillAmount { get; set; }

        /// <summary>
        /// 2019091810299100060000003480
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 账单的状态，INIT：入账；VALID：出账；OVERDUE：逾期；CLEAR：账单结清
        /// </summary>
        [XmlElement("bill_status")]
        public string BillStatus { get; set; }
    }
}
