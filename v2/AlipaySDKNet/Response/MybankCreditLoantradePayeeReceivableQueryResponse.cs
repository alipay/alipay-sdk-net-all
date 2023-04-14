using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoantradePayeeReceivableQueryResponse.
    /// </summary>
    public class MybankCreditLoantradePayeeReceivableQueryResponse : AopResponse
    {
        /// <summary>
        /// 可保理收款金额
        /// </summary>
        [XmlElement("factoring_amt")]
        public CreditPayMoneyVO FactoringAmt { get; set; }

        /// <summary>
        /// 保理费定价
        /// </summary>
        [XmlArray("factoring_fee_pricing")]
        [XmlArrayItem("credit_pay_charge_pricing_v_o")]
        public List<CreditPayChargePricingVO> FactoringFeePricing { get; set; }

        /// <summary>
        /// 保理利率定价
        /// </summary>
        [XmlElement("factoring_int_pricing")]
        public CreditPayIntPricingVO FactoringIntPricing { get; set; }

        /// <summary>
        /// 可提前收款订单数量
        /// </summary>
        [XmlElement("receivable_cnt")]
        public long ReceivableCnt { get; set; }

        /// <summary>
        /// 赊呗应收列表支付宝小程序URL
        /// </summary>
        [XmlElement("receivable_manage_url")]
        public string ReceivableManageUrl { get; set; }

        /// <summary>
        /// 收款日，只有固定收款日期的会返回，表示每月的18号
        /// </summary>
        [XmlElement("remit_date")]
        public string RemitDate { get; set; }

        /// <summary>
        /// 总计应收金额
        /// </summary>
        [XmlElement("total_rcv_amt")]
        public CreditPayMoneyVO TotalRcvAmt { get; set; }
    }
}
