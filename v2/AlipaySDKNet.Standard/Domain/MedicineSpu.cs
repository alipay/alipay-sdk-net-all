using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicineSpu Data Structure.
    /// </summary>
    [Serializable]
    public class MedicineSpu : AopObject
    {
        /// <summary>
        /// 药品类型特有字段，给药途径
        /// </summary>
        [XmlElement("administration_method")]
        public string AdministrationMethod { get; set; }

        /// <summary>
        /// 药品类型特有字段，不良反应
        /// </summary>
        [XmlElement("adverse_reactions")]
        public string AdverseReactions { get; set; }

        /// <summary>
        /// 药品类型特有字段，适用年龄
        /// </summary>
        [XmlElement("applicable_age")]
        public string ApplicableAge { get; set; }

        /// <summary>
        /// 医疗器械类型特有字段，适用范围
        /// </summary>
        [XmlElement("application_scope")]
        public string ApplicationScope { get; set; }

        /// <summary>
        /// 医疗器械传主品的注册证编号或者备案凭证编号，其余传批准文号
        /// </summary>
        [XmlElement("approval_number")]
        public string ApprovalNumber { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// CHINESES_PATENT-中成药 CHEMICALS-化学药 BIOLOGICS-生物制剂 OTHERS-其他
        /// </summary>
        [XmlElement("classification")]
        public string Classification { get; set; }

        /// <summary>
        /// 通用名称，医疗器械传医疗器械审批名称，其余传对应的通用名称
        /// </summary>
        [XmlElement("common_name")]
        public string CommonName { get; set; }

        /// <summary>
        /// 药品、医药保健品类型特有字段，服用使用禁忌
        /// </summary>
        [XmlElement("contraindications")]
        public string Contraindications { get; set; }

        /// <summary>
        /// 医疗器械特有，器械产品名称
        /// </summary>
        [XmlElement("device_common_name")]
        public string DeviceCommonName { get; set; }

        /// <summary>
        /// 医疗器械类型特有字段，且必填，按国家药监审批的型号填写（多品拼合）
        /// </summary>
        [XmlElement("device_spec")]
        public string DeviceSpec { get; set; }

        /// <summary>
        /// 药品、保健品和特医食品特有，保健品和特医食品必填，枚举类型，从以下选择： TABLETS-片剂 CAPSULE-胶囊剂 SOLUTION-溶液剂 SUSPENSION-混悬剂 EMULSION-乳剂 GEL-胶浆剂 LOTION-乳液 COMPOUND_PREPARATION-合剂 TINCTURE-酊剂 DROP-滴剂 SUSPENSION_DROP-混悬滴剂 SYRUP-糖浆剂 PILL-丸剂 DRIPPING_PILL-滴丸 GRANULE-颗粒剂 POWDER-散剂 DUST-粉剂 DUSTING_POWDER-撒粉 TOPICAL_POWDER-撒布剂 OINTMENT-膏剂 CREAM-霜剂 PASTE-糊剂 PATCH-贴剂 FILM-膜剂 TRANSDERMAL_PATCH-透皮贴剂 TOPICAL_SOLUTION-外用溶液剂 WASH-洗剂 MOUTHWASH-漱口剂 MOUTHWASH-含漱液 ORAL_SUSPENSION-胶浆剂 LINIMENT-搽剂 TINCTURE-酊剂 OIL-油剂 LATEX-乳胶剂 GEL-凝胶剂 PAINT-涂剂 FILM_FORMING_AGENT-涂膜剂 TOPICAL_APPLICATION-涂布剂 SUPPOSITORY-栓剂 OPHTHALMIC_DROPS-滴眼剂 OTIC_DROPS-滴耳剂 NASAL_DROPS-滴鼻剂 AEROSOL-气雾剂 POWDER_INHALER-粉雾剂 INHALER-吸入剂 NEBULIZER_SOLUTION-雾化溶液剂 NEBULIZER_SOLUTION-雾化液 INJECTION-注射剂 POWDER_FOR_INJECTION-粉针剂 INJECTABLE-针剂 OTHERS-其他
        /// </summary>
        [XmlElement("dosage_from")]
        public string DosageFrom { get; set; }

        /// <summary>
        /// 保健品类型特有，多选枚举，枚举从以下值选传： 有助于增强免疫力ENHANCING_IMMUNITY 辅助保护化学性肝损伤PROTECTING_FROM_CHEMICAL_LIVER_DAMAGE 有助于抗氧化FIGHTING_OXIDATION 有助于改善痤疮LIGHTENING_ACNE 有助于改善黄褐班LIGHTENING_MELASMA 有助于改善皮肤水份INCREASING_SKIN_MOISTURE 改善皮肤油分REDUCING_SKIN_OILINESS 辅助改善记忆AIDING_MEMORY_IMPROVEMENT 有助于改善睡眠ENHANCING_SLEEP 缓解体力疲劳RELIEVING_PHYSICAL_FATIGUE 清咽润喉SOOTHING_THE_THROAT 有助于控制体内脂肪CONTROLLING_BODY_FAT 有助于改善骨密度IMPROVING_BONE_DENSITY 改善缺铁性贫血TREATING_IRON_DEFICIENCY_ANEMIA 有助于调节肠道菌群REGULATING_GUT_MICROBIOTA 有助于消化AIDING_DIGESTION 有助于润肠通便PROMOTING_BOWEL_MOVEMENT 辅助保护胃粘膜PROTECTING_STOMACH_LINING 有助于维持血脂MAINTAINING_BLOOD_LIPIDS 有助于维持血糖MAINTAINING_BLOOD_SUGAR 有助于维持血压MAINTAINING_BLOOD_PRESSURE 有助于改善骨密度IMPROVING_BONE_DENSITY 有助于排铅HELPING_WITH_LEAD_DETOXIFICATION 缓解视觉疲劳EASING_EYE_TIREDNESS 改善生长发育IMPROVING_GROWTH_DEVELOPMENT 促进泌乳STIMULATING_LACTATION 耐缺氧WITHSTANDING_LOW_OXYGEN 电离辐射辅助保护SUPPORTING_RADIATION_PROTECTION
        /// </summary>
        [XmlArray("efficacies")]
        [XmlArrayItem("string")]
        public List<string> Efficacies { get; set; }

        /// <summary>
        /// 器械、保健品和特医食品类型特有字段，上市许可持有人
        /// </summary>
        [XmlElement("mah")]
        public string Mah { get; set; }

        /// <summary>
        /// 医疗器械类型特有字段，主品医疗器械准入资质
        /// </summary>
        [XmlElement("main_access_qualification")]
        public MedicineAccessQualification MainAccessQualification { get; set; }

        /// <summary>
        /// MEDICINE - 药品 FUNCTIONAL_FOOD - 保健食品 MEDICAL_FOOD - 特殊医学用途食品 MEDICAL_DEVICE - 医疗器械
        /// </summary>
        [XmlElement("main_category")]
        public string MainCategory { get; set; }

        /// <summary>
        /// 通过图片文件上传接口alipay.open.file.upload上传图片后获取文件Id
        /// </summary>
        [XmlElement("main_image")]
        public string MainImage { get; set; }

        /// <summary>
        /// 药品、特医保健品类型特有字段，主要成份
        /// </summary>
        [XmlElement("main_ingredients")]
        public string MainIngredients { get; set; }

        /// <summary>
        /// 医疗器械类型特有字段，且必填，枚举类型
        /// </summary>
        [XmlElement("management_category")]
        public string ManagementCategory { get; set; }

        /// <summary>
        /// 药品、特医保健类型特有字段，生产厂家或企业
        /// </summary>
        [XmlElement("manufacturer_name")]
        public string ManufacturerName { get; set; }

        /// <summary>
        /// 器械、保健品和特医食品类型特有字段，且必传，计量单位
        /// </summary>
        [XmlElement("measurement_unit")]
        public string MeasurementUnit { get; set; }

        /// <summary>
        /// 进/出口标签
        /// </summary>
        [XmlElement("origin_label")]
        public string OriginLabel { get; set; }

        /// <summary>
        /// 商品产地
        /// </summary>
        [XmlElement("origin_place")]
        public string OriginPlace { get; set; }

        /// <summary>
        /// 医疗器械类型特有字段，副品医疗器械准入资质
        /// </summary>
        [XmlArray("other_access_qualifications")]
        [XmlArrayItem("medicine_access_qualification")]
        public List<MedicineAccessQualification> OtherAccessQualifications { get; set; }

        /// <summary>
        /// 通过图片文件上传接口alipay.open.file.upload上传图片后获取文件Id
        /// </summary>
        [XmlArray("other_images")]
        [XmlArrayItem("string")]
        public List<string> OtherImages { get; set; }

        /// <summary>
        /// 药品、特医保健品类型特有字段，性状
        /// </summary>
        [XmlElement("physical_properties")]
        public string PhysicalProperties { get; set; }

        /// <summary>
        /// 药品、特医保健品类型特有字段，注意事项
        /// </summary>
        [XmlElement("precautions")]
        public string Precautions { get; set; }

        /// <summary>
        /// 医疗器械类型特有字段，产品类别，管理类别的补充说明
        /// </summary>
        [XmlElement("product_category")]
        public string ProductCategory { get; set; }

        /// <summary>
        /// 标品69码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 生产许可证号
        /// </summary>
        [XmlElement("production_license_number")]
        public string ProductionLicenseNumber { get; set; }

        /// <summary>
        /// 药品类型特有字段，监管分级
        /// </summary>
        [XmlElement("regulatory_classification")]
        public string RegulatoryClassification { get; set; }

        /// <summary>
        /// 保质期
        /// </summary>
        [XmlElement("shelf_life")]
        public string ShelfLife { get; set; }

        /// <summary>
        /// 包装规格
        /// </summary>
        [XmlElement("specification")]
        public string Specification { get; set; }

        /// <summary>
        /// 贮藏条件
        /// </summary>
        [XmlElement("storage_conditions")]
        public string StorageConditions { get; set; }

        /// <summary>
        /// 医疗器械类型特有字段，结构及组成
        /// </summary>
        [XmlElement("structure_composition")]
        public string StructureComposition { get; set; }

        /// <summary>
        /// 子品牌名
        /// </summary>
        [XmlElement("sub_brand_name")]
        public string SubBrandName { get; set; }

        /// <summary>
        /// 药品、特医保健品类型特有字段，适宜人群
        /// </summary>
        [XmlElement("suitable_population")]
        public string SuitablePopulation { get; set; }

        /// <summary>
        /// 药品类型特有字段，功能主治
        /// </summary>
        [XmlElement("therapeutic_efficacy")]
        public string TherapeuticEfficacy { get; set; }

        /// <summary>
        /// 药品类型专有字段，商标名称
        /// </summary>
        [XmlElement("trademark_name")]
        public string TrademarkName { get; set; }

        /// <summary>
        /// 药品、特医保健品类型特有字段，不适宜人群
        /// </summary>
        [XmlElement("unsuitable_population")]
        public string UnsuitablePopulation { get; set; }

        /// <summary>
        /// 外部标品唯一id
        /// </summary>
        [XmlElement("upc")]
        public string Upc { get; set; }

        /// <summary>
        /// 特医保健品类型特有字段，食用方法及食用量
        /// </summary>
        [XmlElement("usage_method_amount")]
        public string UsageMethodAmount { get; set; }
    }
}
