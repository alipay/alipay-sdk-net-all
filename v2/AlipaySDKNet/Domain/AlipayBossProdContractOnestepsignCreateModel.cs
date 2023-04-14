using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdContractOnestepsignCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdContractOnestepsignCreateModel : AopObject
    {
        /// <summary>
        /// 合同金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 金额类型（ESTIMATE：预估；NONE：无金额；DEFINE：固定）
        /// </summary>
        [XmlElement("amount_type")]
        public string AmountType { get; set; }

        /// <summary>
        /// 倒签流水号
        /// </summary>
        [XmlElement("ante_dated_voucher_id")]
        public string AnteDatedVoucherId { get; set; }

        /// <summary>
        /// 申请人
        /// </summary>
        [XmlElement("apply_people")]
        public ContractPeople ApplyPeople { get; set; }

        /// <summary>
        /// 审批示例唯一值
        /// </summary>
        [XmlElement("approve_instant_id")]
        public string ApproveInstantId { get; set; }

        /// <summary>
        /// 自动续约周期单位（只有当InEffectType = AUTO_RENEW时需要；取值：YEAR:年；MONTH:月；DAY:日）
        /// </summary>
        [XmlElement("auto_renew_period")]
        public string AutoRenewPeriod { get; set; }

        /// <summary>
        /// 请求id
        /// </summary>
        [XmlElement("business_id")]
        public string BusinessId { get; set; }

        /// <summary>
        /// 业务线
        /// </summary>
        [XmlElement("business_line")]
        public string BusinessLine { get; set; }

        /// <summary>
        /// 背景描述
        /// </summary>
        [XmlElement("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// 合同附件文件(允许多个)
        /// </summary>
        [XmlArray("contract_attaches")]
        [XmlArrayItem("contract_attach")]
        public List<ContractAttach> ContractAttaches { get; set; }

        /// <summary>
        /// 合同中心生成的合同编号
        /// </summary>
        [XmlElement("contract_code")]
        public string ContractCode { get; set; }

        /// <summary>
        /// 合同正文文件(只能有一个)
        /// </summary>
        [XmlElement("contract_doc")]
        public ContractAttach ContractDoc { get; set; }

        /// <summary>
        /// 合同有效时长
        /// </summary>
        [XmlElement("contract_duration")]
        public string ContractDuration { get; set; }

        /// <summary>
        /// 合同名称
        /// </summary>
        [XmlElement("contract_name")]
        public string ContractName { get; set; }

        /// <summary>
        /// 签约方式（PHY_SEAL：实体章）
        /// </summary>
        [XmlElement("contract_sign_type")]
        public string ContractSignType { get; set; }

        /// <summary>
        /// 合同币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 实体章我方先用印的交件方式（PRINT：用印法务直接打印（无需交件)；DELIVERY：使用对方纸质版本用印（需现场交件））
        /// </summary>
        [XmlElement("delivery_type")]
        public string DeliveryType { get; set; }

        /// <summary>
        /// 合同有效时长单位(YEAR:年；MONTH:月；DAY:日)
        /// </summary>
        [XmlElement("duration_unit")]
        public string DurationUnit { get; set; }

        /// <summary>
        /// 生效时间
        /// </summary>
        [XmlElement("effect_time")]
        public string EffectTime { get; set; }

        /// <summary>
        /// 合同生效方式（AFTER_SEAL：盖章后生效；FIX_DATE：约定开始时间）
        /// </summary>
        [XmlElement("effect_type")]
        public string EffectType { get; set; }

        /// <summary>
        /// 失效时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 扩展信息【详见扩展字段】
        /// </summary>
        [XmlElement("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 五级合同类型
        /// </summary>
        [XmlElement("fifth_contract_type")]
        public string FifthContractType { get; set; }

        /// <summary>
        /// 一级合同类型：置业固定值-non_standard
        /// </summary>
        [XmlElement("first_contract_type")]
        public string FirstContractType { get; set; }

        /// <summary>
        /// 四级合同类型
        /// </summary>
        [XmlElement("fourth_contract_type")]
        public string FourthContractType { get; set; }

        /// <summary>
        /// 实体章交还类型。纸质用印必填（INTERNAL_SEVEN_DAYS：国内7天；INTERNATIONAL_FOURTEEN_DAYS：国外14天）
        /// </summary>
        [XmlElement("give_back_type")]
        public string GiveBackType { get; set; }

        /// <summary>
        /// 负责人
        /// </summary>
        [XmlArray("in_charge_people")]
        [XmlArrayItem("contract_people")]
        public List<ContractPeople> InChargePeople { get; set; }

        /// <summary>
        /// 合同失效方式（FIX_DATE：约定终止时间；EFFECT_FOREVER：长期有效；TERMINATE_BY_PERFORMANCE_END：履行完结终止；AUTO_RENEW：自动续约）
        /// </summary>
        [XmlElement("in_effect_type")]
        public string InEffectType { get; set; }

        /// <summary>
        /// 开票方（PURCHASE：采购方开票；SALE：销售方开票；NONE：不开票）
        /// </summary>
        [XmlElement("invoice_target")]
        public string InvoiceTarget { get; set; }

        /// <summary>
        /// 发票类型（NONE：无票；SPECIAL_TICKET：专票；GENERAL_TICKET：普票）
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 法务，可以多个
        /// </summary>
        [XmlArray("legal_people")]
        [XmlArrayItem("contract_people")]
        public List<ContractPeople> LegalPeople { get; set; }

        /// <summary>
        /// 合同份数
        /// </summary>
        [XmlElement("number")]
        public string Number { get; set; }

        /// <summary>
        /// 合同我方公司
        /// </summary>
        [XmlArray("part_a")]
        [XmlArrayItem("partner")]
        public List<Partner> PartA { get; set; }

        /// <summary>
        /// 合同对方公司
        /// </summary>
        [XmlArray("part_b")]
        [XmlArrayItem("partner")]
        public List<Partner> PartB { get; set; }

        /// <summary>
        /// 付款方（PARTA：我方；PARTB：对方）
        /// </summary>
        [XmlElement("payer")]
        public string Payer { get; set; }

        /// <summary>
        /// 如果signType = SignType.PHY_SEAL时候填写 实体章类型（CONTRACT_SEAL：合同章；PUB_SEAL：公章）
        /// </summary>
        [XmlElement("phy_seal_type")]
        public string PhySealType { get; set; }

        /// <summary>
        /// 实体章用印备注
        /// </summary>
        [XmlElement("remarks_on_printing")]
        public string RemarksOnPrinting { get; set; }

        /// <summary>
        /// 如果signType = SignType.P phySealTypeHY_SEAL时候填写 用印顺序（FROM_PARTA：我方先用印；FROM_PARTB：对方先用印）
        /// </summary>
        [XmlElement("seal_order")]
        public string SealOrder { get; set; }

        /// <summary>
        /// 二级合同类型
        /// </summary>
        [XmlElement("second_contract_type")]
        public string SecondContractType { get; set; }

        /// <summary>
        /// 签约参数
        /// </summary>
        [XmlArray("sign_params")]
        [XmlArrayItem("seal_display_request")]
        public List<SealDisplayRequest> SignParams { get; set; }

        /// <summary>
        /// 六级合同类型
        /// </summary>
        [XmlElement("sixth_contract_type")]
        public string SixthContractType { get; set; }

        /// <summary>
        /// 当前系统的名称
        /// </summary>
        [XmlElement("source_system_id")]
        public string SourceSystemId { get; set; }

        /// <summary>
        /// 税率,0-100
        /// </summary>
        [XmlElement("tax_rate")]
        public string TaxRate { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }

        /// <summary>
        /// 三级合同类型
        /// </summary>
        [XmlElement("third_contract_type")]
        public string ThirdContractType { get; set; }

        /// <summary>
        /// 签约类型(CONTRACT：合同；FILE：文件)
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
