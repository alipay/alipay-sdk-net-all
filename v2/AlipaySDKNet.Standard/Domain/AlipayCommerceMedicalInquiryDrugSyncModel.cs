using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInquiryDrugSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInquiryDrugSyncModel : AopObject
    {
        /// <summary>
        /// 与UPC码至少一个非空
        /// </summary>
        [XmlElement("approval_number")]
        public string ApprovalNumber { get; set; }

        /// <summary>
        /// 中药国标编码
        /// </summary>
        [XmlElement("chinese_standard_code")]
        public string ChineseStandardCode { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [XmlElement("data_version")]
        public string DataVersion { get; set; }

        /// <summary>
        /// qd 每日1次/bid 每日2次/tid 每日3次/qid 每日4次/qod 隔日1次/qn 每晚1次/qh 每小时/q4h 每4小时/q12h 每12小时/ac 饭前/pc 饭后/hs 睡时/am 上午/pm 下午/st 立即/sos 必要时/prm 按情酌定/cito 紧急
        /// </summary>
        [XmlElement("default_frequency")]
        public string DefaultFrequency { get; set; }

        /// <summary>
        /// 舌下给药/含服给药/口服给药/静脉注射/肌内注射/皮下注射/皮内注射/动脉注射/鞘内注射/关节腔注射/眼内注射/腹腔给药/脑室内注射/椎管内注射/气管内给药/局部注射/注射给药/表皮给药/眼部给药/耳部给药/鼻腔给药/直肠给药/阴道给药/尿道给药/消化道插管给药/吸入给药/口腔给药/植入给药/静脉滴注/其他途径
        /// </summary>
        [XmlElement("default_route")]
        public string DefaultRoute { get; set; }

        /// <summary>
        /// 药品剂型
        /// </summary>
        [XmlElement("dosage_form")]
        public string DosageForm { get; set; }

        /// <summary>
        /// 化学药
        /// </summary>
        [XmlElement("drug_category")]
        public string DrugCategory { get; set; }

        /// <summary>
        /// 药品分类
        /// </summary>
        [XmlElement("drug_classification")]
        public string DrugClassification { get; set; }

        /// <summary>
        /// 药品通用名
        /// </summary>
        [XmlElement("drug_generic_name")]
        public string DrugGenericName { get; set; }

        /// <summary>
        /// 原始药品ID
        /// </summary>
        [XmlElement("drug_id")]
        public string DrugId { get; set; }

        /// <summary>
        /// 原始药品名称
        /// </summary>
        [XmlElement("drug_name")]
        public string DrugName { get; set; }

        /// <summary>
        /// 药品拼音码
        /// </summary>
        [XmlElement("drug_pinyin_code")]
        public string DrugPinyinCode { get; set; }

        /// <summary>
        /// ENABLED/DISABLED
        /// </summary>
        [XmlElement("drug_status")]
        public string DrugStatus { get; set; }

        /// <summary>
        /// 药品商品名
        /// </summary>
        [XmlElement("drug_trade_name")]
        public string DrugTradeName { get; set; }

        /// <summary>
        /// 原始医院ID
        /// </summary>
        [XmlElement("hospital_id")]
        public string HospitalId { get; set; }

        /// <summary>
        /// 是否院内自制剂
        /// </summary>
        [XmlElement("is_hospital_preparation")]
        public string IsHospitalPreparation { get; set; }

        /// <summary>
        /// 是否原研药
        /// </summary>
        [XmlElement("is_original_drug")]
        public string IsOriginalDrug { get; set; }

        /// <summary>
        /// 服务商编码
        /// </summary>
        [XmlElement("isv_code")]
        public string IsvCode { get; set; }

        /// <summary>
        /// 生产厂家
        /// </summary>
        [XmlElement("manufacturer")]
        public string Manufacturer { get; set; }

        /// <summary>
        /// 医保编码
        /// </summary>
        [XmlElement("medical_insurance_code")]
        public string MedicalInsuranceCode { get; set; }

        /// <summary>
        /// 最小剂量单位，单位：mg
        /// </summary>
        [XmlElement("min_dose_unit")]
        public string MinDoseUnit { get; set; }

        /// <summary>
        /// 最小包装单位，单位：包
        /// </summary>
        [XmlElement("min_package_unit")]
        public string MinPackageUnit { get; set; }

        /// <summary>
        /// 产地
        /// </summary>
        [XmlElement("origin")]
        public string Origin { get; set; }

        /// <summary>
        /// 药库单位
        /// </summary>
        [XmlElement("pharmacy_unit")]
        public string PharmacyUnit { get; set; }

        /// <summary>
        /// 来源平台编码
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 处方药/甲类OTC/乙类OTC
        /// </summary>
        [XmlElement("regulatory_level")]
        public string RegulatoryLevel { get; set; }

        /// <summary>
        /// 包装规格，单位：包/千克
        /// </summary>
        [XmlElement("specification")]
        public string Specification { get; set; }

        /// <summary>
        /// 与批准文号至少一个非空
        /// </summary>
        [XmlElement("upc_code")]
        public string UpcCode { get; set; }
    }
}
