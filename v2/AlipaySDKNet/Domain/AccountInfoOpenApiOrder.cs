using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AccountInfoOpenApiOrder Data Structure.
    /// </summary>
    [Serializable]
    public class AccountInfoOpenApiOrder : AopObject
    {
        /// <summary>
        /// 科目段编码
        /// </summary>
        [XmlElement("account_code")]
        public string AccountCode { get; set; }

        /// <summary>
        /// 科目段描述
        /// </summary>
        [XmlElement("account_desc")]
        public string AccountDesc { get; set; }

        /// <summary>
        /// 入帐日期，格式yyyyMMdd
        /// </summary>
        [XmlElement("accounting_date")]
        public string AccountingDate { get; set; }

        /// <summary>
        /// 会计期间,格式yyyyMM
        /// </summary>
        [XmlElement("accounting_month")]
        public string AccountingMonth { get; set; }

        /// <summary>
        /// 借贷类型编码
        /// </summary>
        [XmlElement("accounting_type_code")]
        public string AccountingTypeCode { get; set; }

        /// <summary>
        /// 原币发生额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 本位币发生额
        /// </summary>
        [XmlElement("amount_beq")]
        public string AmountBeq { get; set; }

        /// <summary>
        /// 预算部门段编码
        /// </summary>
        [XmlElement("budget_dept_code")]
        public string BudgetDeptCode { get; set; }

        /// <summary>
        /// 预算部门段描述
        /// </summary>
        [XmlElement("budget_dept_desc")]
        public string BudgetDeptDesc { get; set; }

        /// <summary>
        /// 公司段
        /// </summary>
        [XmlElement("company_code")]
        public string CompanyCode { get; set; }

        /// <summary>
        /// 公司段描述
        /// </summary>
        [XmlElement("company_desc")]
        public string CompanyDesc { get; set; }

        /// <summary>
        /// 成本中心段编码
        /// </summary>
        [XmlElement("cost_center_code")]
        public string CostCenterCode { get; set; }

        /// <summary>
        /// 成本中心段描述
        /// </summary>
        [XmlElement("cost_center_desc")]
        public string CostCenterDesc { get; set; }

        /// <summary>
        /// 原币币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 本位币币种
        /// </summary>
        [XmlElement("currency_beq")]
        public string CurrencyBeq { get; set; }

        /// <summary>
        /// 明细段编码
        /// </summary>
        [XmlElement("detail_code")]
        public string DetailCode { get; set; }

        /// <summary>
        /// 明细段描述
        /// </summary>
        [XmlElement("detail_desc")]
        public string DetailDesc { get; set; }

        /// <summary>
        /// 行业段编码
        /// </summary>
        [XmlElement("industry_code")]
        public string IndustryCode { get; set; }

        /// <summary>
        /// 行业段描述
        /// </summary>
        [XmlElement("industry_desc")]
        public string IndustryDesc { get; set; }

        /// <summary>
        /// 往来段编码
        /// </summary>
        [XmlElement("inter_company_code")]
        public string InterCompanyCode { get; set; }

        /// <summary>
        /// 往来段描述
        /// </summary>
        [XmlElement("inter_company_desc")]
        public string InterCompanyDesc { get; set; }

        /// <summary>
        /// 日记账行说明
        /// </summary>
        [XmlElement("je_line_desc")]
        public string JeLineDesc { get; set; }

        /// <summary>
        /// 产品段编码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 产品段描述
        /// </summary>
        [XmlElement("product_desc")]
        public string ProductDesc { get; set; }

        /// <summary>
        /// 项目段编码
        /// </summary>
        [XmlElement("project_code")]
        public string ProjectCode { get; set; }

        /// <summary>
        /// 项目段描述
        /// </summary>
        [XmlElement("project_desc")]
        public string ProjectDesc { get; set; }

        /// <summary>
        /// 区域段编码
        /// </summary>
        [XmlElement("region_code")]
        public string RegionCode { get; set; }

        /// <summary>
        /// 区域段描述
        /// </summary>
        [XmlElement("region_desc")]
        public string RegionDesc { get; set; }

        /// <summary>
        /// 备用段1
        /// </summary>
        [XmlElement("spare_code_1")]
        public string SpareCode1 { get; set; }

        /// <summary>
        /// 备用段2编码
        /// </summary>
        [XmlElement("spare_code_2")]
        public string SpareCode2 { get; set; }

        /// <summary>
        /// 备用段1描述
        /// </summary>
        [XmlElement("spare_desc_1")]
        public string SpareDesc1 { get; set; }

        /// <summary>
        /// 备用段2描述
        /// </summary>
        [XmlElement("spare_desc_2")]
        public string SpareDesc2 { get; set; }

        /// <summary>
        /// 凭证号
        /// </summary>
        [XmlElement("voucher_no")]
        public string VoucherNo { get; set; }
    }
}
