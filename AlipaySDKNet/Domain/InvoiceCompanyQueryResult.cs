using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceCompanyQueryResult Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceCompanyQueryResult : AopObject
    {
        /// <summary>
        /// 发票限额信息
        /// </summary>
        [XmlArray("amount_limit_dto_list")]
        [XmlArrayItem("invoice_amount_limit_d_t_o")]
        public List<InvoiceAmountLimitDTO> AmountLimitDtoList { get; set; }

        /// <summary>
        /// 企业税务信息
        /// </summary>
        [XmlElement("invoice_company_dto")]
        public InvoiceCompanyDTO InvoiceCompanyDto { get; set; }

        /// <summary>
        /// 税号已开通产品信息
        /// </summary>
        [XmlArray("invoice_open_product_dto_list")]
        [XmlArrayItem("invoice_open_product_d_t_o")]
        public List<InvoiceOpenProductDTO> InvoiceOpenProductDtoList { get; set; }

        /// <summary>
        /// 入驻工单ID
        /// </summary>
        [XmlElement("register_id")]
        public string RegisterId { get; set; }

        /// <summary>
        /// 入驻工单状态
        /// </summary>
        [XmlElement("register_status")]
        public long RegisterStatus { get; set; }
    }
}
