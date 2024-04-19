using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoantradePayerBillrepayConsultResponse.
    /// </summary>
    public class MybankCreditLoantradePayerBillrepayConsultResponse : AopResponse
    {
        /// <summary>
        /// 账单详情视图列表
        /// </summary>
        [XmlArray("bill_details")]
        [XmlArrayItem("credit_pay_bill_detail_v_o")]
        public List<CreditPayBillDetailVO> BillDetails { get; set; }

        /// <summary>
        /// 是否存在账单，只有为true，除repay_url外的其它字段，才会存在
        /// </summary>
        [XmlElement("exist_bill")]
        public bool ExistBill { get; set; }

        /// <summary>
        /// 还款链接
        /// </summary>
        [XmlElement("repay_url")]
        public string RepayUrl { get; set; }
    }
}
