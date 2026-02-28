using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IitBizDetailBillDetailOpenApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class IitBizDetailBillDetailOpenApiDTO : AopObject
    {
        /// <summary>
        /// 实发金额
        /// </summary>
        [XmlElement("actual_amount")]
        public MultiCurrencyMoneyOpenApi ActualAmount { get; set; }

        /// <summary>
        /// 账单金额
        /// </summary>
        [XmlElement("bill_amt")]
        public MultiCurrencyMoneyOpenApi BillAmt { get; set; }

        /// <summary>
        /// 出生日期
        /// </summary>
        [XmlElement("birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// 券模版ID
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务场景码
        /// </summary>
        [XmlElement("biz_scene_code")]
        public string BizSceneCode { get; set; }

        /// <summary>
        /// 城建税
        /// </summary>
        [XmlElement("city_main_const_tax_amount")]
        public MultiCurrencyMoneyOpenApi CityMainConstTaxAmount { get; set; }

        /// <summary>
        /// 联系方式
        /// </summary>
        [XmlElement("contact")]
        public string Contact { get; set; }

        /// <summary>
        /// 国籍
        /// </summary>
        [XmlElement("country")]
        public string Country { get; set; }

        /// <summary>
        /// 残疾证号码
        /// </summary>
        [XmlElement("disability_cert_no")]
        public string DisabilityCertNo { get; set; }

        /// <summary>
        /// 教育附加
        /// </summary>
        [XmlElement("edu_surcharge_amount")]
        public MultiCurrencyMoneyOpenApi EduSurchargeAmount { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 计税明细唯一标识
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 上游的唯一标识
        /// </summary>
        [XmlElement("idempotent_id")]
        public string IdempotentId { get; set; }

        /// <summary>
        /// 个人所得税
        /// </summary>
        [XmlElement("iit_amount")]
        public MultiCurrencyMoneyOpenApi IitAmount { get; set; }

        /// <summary>
        /// 个税项目
        /// </summary>
        [XmlElement("iit_project")]
        public string IitProject { get; set; }

        /// <summary>
        /// 机构ID
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 地方教育附加
        /// </summary>
        [XmlElement("local_edu_surcharge_amount")]
        public MultiCurrencyMoneyOpenApi LocalEduSurchargeAmount { get; set; }

        /// <summary>
        /// 期间，月份
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }

        /// <summary>
        /// 税金承担方式
        /// </summary>
        [XmlElement("tax_base_type")]
        public string TaxBaseType { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("taxpayer_cert_no")]
        public string TaxpayerCertNo { get; set; }

        /// <summary>
        /// 纳税人证件类型
        /// </summary>
        [XmlElement("taxpayer_cert_type")]
        public string TaxpayerCertType { get; set; }

        /// <summary>
        /// 纳税人名称
        /// </summary>
        [XmlElement("taxpayer_name")]
        public string TaxpayerName { get; set; }

        /// <summary>
        /// 税金合计，个税+增值税+附加
        /// </summary>
        [XmlElement("total_tax_amount")]
        public MultiCurrencyMoneyOpenApi TotalTaxAmount { get; set; }

        /// <summary>
        /// 是否残疾
        /// </summary>
        [XmlElement("user_is_disability")]
        public string UserIsDisability { get; set; }

        /// <summary>
        /// 增值税
        /// </summary>
        [XmlElement("vat_amount")]
        public MultiCurrencyMoneyOpenApi VatAmount { get; set; }
    }
}
