using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserBillStatQueryResponse.
    /// </summary>
    public class AlipayUserBillStatQueryResponse : AopResponse
    {
        /// <summary>
        /// 实付金额，单位元
        /// </summary>
        [XmlElement("expenditure_amount")]
        public string ExpenditureAmount { get; set; }

        /// <summary>
        /// 实收金额，单位元
        /// </summary>
        [XmlElement("income_amount")]
        public string IncomeAmount { get; set; }
    }
}
