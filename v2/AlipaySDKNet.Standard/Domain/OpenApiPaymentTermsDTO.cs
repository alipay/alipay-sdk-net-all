using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiPaymentTermsDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiPaymentTermsDTO : AopObject
    {
        /// <summary>
        /// 合同Id
        /// </summary>
        [XmlElement("contract_id")]
        public string ContractId { get; set; }

        /// <summary>
        /// 合同支付条款头ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 是否默认，y:是；n:否
        /// </summary>
        [XmlElement("is_default")]
        public string IsDefault { get; set; }

        /// <summary>
        /// 其他条款
        /// </summary>
        [XmlElement("other_terms")]
        public string OtherTerms { get; set; }

        /// <summary>
        /// 是否按已支付比例为准
        /// </summary>
        [XmlElement("pay_on_percent")]
        public string PayOnPercent { get; set; }

        /// <summary>
        /// 支付条款名称，货到付款,阶段付款,阶段付款(工程版)
        /// </summary>
        [XmlElement("payment_name")]
        public string PaymentName { get; set; }

        /// <summary>
        /// 合同支付条款行表
        /// </summary>
        [XmlArray("payment_terms_item_list")]
        [XmlArrayItem("open_api_payment_terms_item_d_t_o")]
        public List<OpenApiPaymentTermsItemDTO> PaymentTermsItemList { get; set; }

        /// <summary>
        /// 付款类型      *      * 货到付款：PAY_AFTER_RECEIPT 对应原来的：PAY_ON_DELIVERY      *      * 阶段支付：MILESTONE 对应原来的：PAY_ON_MILESTONE      *      * 阶段支付（工程版）：MILESTONE_COST      *      * 混合型：MIX
        /// </summary>
        [XmlElement("payment_type")]
        public string PaymentType { get; set; }

        /// <summary>
        /// 支付条款顺序
        /// </summary>
        [XmlElement("sort")]
        public string Sort { get; set; }

        /// <summary>
        /// 条款来源
        /// </summary>
        [XmlElement("term_source")]
        public string TermSource { get; set; }
    }
}
