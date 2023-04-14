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
        /// 机构号
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 开票年月 yyyyMM
        /// </summary>
        [XmlElement("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 货物名称
        /// </summary>
        [XmlElement("invoice_product_name")]
        public string InvoiceProductName { get; set; }

        /// <summary>
        /// 规格型号，可为空
        /// </summary>
        [XmlElement("invoice_specification")]
        public string InvoiceSpecification { get; set; }

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
        /// 税率
        /// </summary>
        [XmlElement("tax_rate")]
        public string TaxRate { get; set; }

        /// <summary>
        /// 税收类型 02 营业税;01 增值税;00 无税
        /// </summary>
        [XmlElement("tax_type")]
        public string TaxType { get; set; }
    }
}
