using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceArrivalDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceArrivalDTO : AopObject
    {
        /// <summary>
        /// 发票到票明细DTO列表
        /// </summary>
        [XmlArray("invoice_arrival_detail_dtos")]
        [XmlArrayItem("invoice_arrival_detail_d_t_o")]
        public List<InvoiceArrivalDetailDTO> InvoiceArrivalDetailDtos { get; set; }

        /// <summary>
        /// 发票账单ID
        /// </summary>
        [XmlElement("invoice_bill_id")]
        public string InvoiceBillId { get; set; }

        /// <summary>
        /// 开票账单号
        /// </summary>
        [XmlElement("invoice_bill_no")]
        public string InvoiceBillNo { get; set; }

        /// <summary>
        /// 使用金额（单位：各币种的“元”单位，精确到小数点后2位）
        /// </summary>
        [XmlElement("use_amount")]
        public string UseAmount { get; set; }

        /// <summary>
        /// 代扣税金额（单位：各币种的“元”单位，精确到小数点后2位）
        /// </summary>
        [XmlElement("wht_amount")]
        public string WhtAmount { get; set; }

        /// <summary>
        /// 代扣税税率
        /// </summary>
        [XmlElement("wht_rate")]
        public string WhtRate { get; set; }
    }
}
