using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceScrappednaturaltaxQueryResponse.
    /// </summary>
    public class AlipayCommerceEcRecyclinginvoiceScrappednaturaltaxQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前年度乐企个税累计计税金额（元）
        /// </summary>
        [XmlElement("individual_tax_accumulated_amount_current_year")]
        public string IndividualTaxAccumulatedAmountCurrentYear { get; set; }

        /// <summary>
        /// 是否阻断反向开票：Y/N
        /// </summary>
        [XmlElement("interrupt")]
        public string Interrupt { get; set; }

        /// <summary>
        /// 自然人开票信息列表，如自然人无开票信息则为空
        /// </summary>
        [XmlArray("invoice_amount_list")]
        [XmlArrayItem("natrual_person_invoice_amount_monthly")]
        public List<NatrualPersonInvoiceAmountMonthly> InvoiceAmountList { get; set; }

        /// <summary>
        /// 当年已缴个税累计税额（元）
        /// </summary>
        [XmlElement("paid_individual_tax_amount_current_year")]
        public string PaidIndividualTaxAmountCurrentYear { get; set; }

        /// <summary>
        /// 用于税费计算
        /// </summary>
        [XmlArray("scrapped_tax_calc_item_list")]
        [XmlArrayItem("recycling_scrapped_tax_calc_item")]
        public List<RecyclingScrappedTaxCalcItem> ScrappedTaxCalcItemList { get; set; }

        /// <summary>
        /// 普票1%口径待缴累计金额（元）
        /// </summary>
        [XmlElement("wait_pay_general_invoice_1")]
        public string WaitPayGeneralInvoice1 { get; set; }

        /// <summary>
        /// 地方教育附加，教育附加待缴累计金额（元）
        /// </summary>
        [XmlElement("wait_pay_general_invoice_edu_amount")]
        public string WaitPayGeneralInvoiceEduAmount { get; set; }

        /// <summary>
        /// 专票待补缴累计金额1%（元）
        /// </summary>
        [XmlElement("wait_pay_special_invoice_1")]
        public string WaitPaySpecialInvoice1 { get; set; }

        /// <summary>
        /// 专票3%待补缴累计金额（元）
        /// </summary>
        [XmlElement("wait_pay_special_invoice_3")]
        public string WaitPaySpecialInvoice3 { get; set; }
    }
}
