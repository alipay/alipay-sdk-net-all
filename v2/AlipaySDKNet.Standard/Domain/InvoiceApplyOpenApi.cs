using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceApplyOpenApi Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceApplyOpenApi : AopObject
    {
        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("amount")]
        public MultiCurrencyMoneyOpenApi Amount { get; set; }

        /// <summary>
        /// 合约号
        /// </summary>
        [XmlElement("arrangement_no")]
        public string ArrangementNo { get; set; }

        /// <summary>
        /// 免税类型，当为免税时此字段应该有值
        /// </summary>
        [XmlElement("duty_free_type")]
        public string DutyFreeType { get; set; }

        /// <summary>
        /// 票面展示的费用期间
        /// </summary>
        [XmlElement("fee_interval_format_str")]
        public string FeeIntervalFormatStr { get; set; }

        /// <summary>
        /// 机构号
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 外部指定的展示在票面的开票时间 格式为yyyyMMdd
        /// </summary>
        [XmlElement("inv_dt")]
        public string InvDt { get; set; }

        /// <summary>
        /// 开票时间、账单月 格式为yyyyMM
        /// </summary>
        [XmlElement("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [XmlElement("invoice_line_measurement_unit")]
        public string InvoiceLineMeasurementUnit { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [XmlElement("invoice_line_quantity")]
        public string InvoiceLineQuantity { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        [XmlElement("invoice_line_unit_amount")]
        public string InvoiceLineUnitAmount { get; set; }

        /// <summary>
        /// 发票备注
        /// </summary>
        [XmlElement("invoice_note")]
        public string InvoiceNote { get; set; }

        /// <summary>
        /// 货物名称
        /// </summary>
        [XmlElement("invoice_product_name")]
        public string InvoiceProductName { get; set; }

        /// <summary>
        /// 外部指定的发票行内容后缀
        /// </summary>
        [XmlElement("invoice_product_name_suffix")]
        public string InvoiceProductNameSuffix { get; set; }

        /// <summary>
        /// 规格型号，可为空
        /// </summary>
        [XmlElement("invoice_specification")]
        public string InvoiceSpecification { get; set; }

        /// <summary>
        /// 此属性可以用作发票的拆分KEY
        /// </summary>
        [XmlElement("invoice_split_key")]
        public string InvoiceSplitKey { get; set; }

        /// <summary>
        /// 开票类型
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 商户MID
        /// </summary>
        [XmlElement("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 结算对象参与者角色标识
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 外部单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 详见OutputInvoiceReceiptOutBizTypeEnum
        /// </summary>
        [XmlElement("out_biz_type")]
        public string OutBizType { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 是否全部回款
        /// </summary>
        [XmlElement("received")]
        public string Received { get; set; }

        /// <summary>
        /// 注册地区域码 如：新加坡（SG）,香港（HK）
        /// </summary>
        [XmlElement("register_country")]
        public string RegisterCountry { get; set; }

        /// <summary>
        /// 服务月份
        /// </summary>
        [XmlElement("service_mth")]
        public string ServiceMth { get; set; }

        /// <summary>
        /// 外部单据来源系统标识和开票时一致
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 指定开票金额
        /// </summary>
        [XmlElement("specify_apply_amount")]
        public string SpecifyApplyAmount { get; set; }

        /// <summary>
        /// 税收分类编码，非必填
        /// </summary>
        [XmlElement("tax_classification_code")]
        public string TaxClassificationCode { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [XmlElement("tax_rate")]
        public string TaxRate { get; set; }

        /// <summary>
        /// 免税标识（无发票：NO_INVOICE，零税率：ZERO_TAX_RATE，免税：EXEMPTION，无税收监管：NO_TAX_REGULATION）
        /// </summary>
        [XmlElement("tax_rate_tags")]
        public string TaxRateTags { get; set; }

        /// <summary>
        /// 税收类型 02 营业税;01 增值税;00 无税
        /// </summary>
        [XmlElement("tax_type")]
        public string TaxType { get; set; }
    }
}
