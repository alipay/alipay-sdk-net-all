using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcTcnOpeninvoiceapplySubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcTcnOpeninvoiceapplySubmitModel : AopObject
    {
        /// <summary>
        /// 开票申请明细列表
        /// </summary>
        [XmlArray("apply_detail_list")]
        [XmlArrayItem("open_invoice_apply_detail")]
        public List<OpenInvoiceApplyDetail> ApplyDetailList { get; set; }

        /// <summary>
        /// 购方地址
        /// </summary>
        [XmlElement("buyer_address")]
        public string BuyerAddress { get; set; }

        /// <summary>
        /// 购方银行账号
        /// </summary>
        [XmlElement("buyer_bank_account")]
        public string BuyerBankAccount { get; set; }

        /// <summary>
        /// 购方开户行
        /// </summary>
        [XmlElement("buyer_bank_name")]
        public string BuyerBankName { get; set; }

        /// <summary>
        /// 购方名称
        /// </summary>
        [XmlElement("buyer_name")]
        public string BuyerName { get; set; }

        /// <summary>
        /// 购方税号
        /// </summary>
        [XmlElement("buyer_tax_no")]
        public string BuyerTaxNo { get; set; }

        /// <summary>
        /// 购方电话
        /// </summary>
        [XmlElement("buyer_tel")]
        public string BuyerTel { get; set; }

        /// <summary>
        /// 行业类型
        /// </summary>
        [XmlElement("industry_type")]
        public string IndustryType { get; set; }

        /// <summary>
        /// 申请开票金额（元）
        /// </summary>
        [XmlElement("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 发票类型
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 平台申请ID
        /// </summary>
        [XmlElement("platform_apply_id")]
        public string PlatformApplyId { get; set; }

        /// <summary>
        /// 行程信息列表
        /// </summary>
        [XmlArray("travel_info_list")]
        [XmlArrayItem("open_invoice_travel_info")]
        public List<OpenInvoiceTravelInfo> TravelInfoList { get; set; }
    }
}
