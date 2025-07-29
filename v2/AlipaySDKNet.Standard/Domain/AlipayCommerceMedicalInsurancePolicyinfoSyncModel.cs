using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInsurancePolicyinfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInsurancePolicyinfoSyncModel : AopObject
    {
        /// <summary>
        /// 保司类型
        /// </summary>
        [XmlElement("company_type")]
        public string CompanyType { get; set; }

        /// <summary>
        /// 缴费方式，枚举值 （新增必填）
        /// </summary>
        [XmlElement("continuous_frequency")]
        public string ContinuousFrequency { get; set; }

        /// <summary>
        /// 缴费期限文本描述，10Y/20Y/50A等，10Y代表10年，50A代表缴至50周岁，不可枚举 （新增必填）
        /// </summary>
        [XmlElement("continuous_period")]
        public string ContinuousPeriod { get; set; }

        /// <summary>
        /// 缴费计划
        /// </summary>
        [XmlArray("continuous_plan_list")]
        [XmlArrayItem("continuous_plan")]
        public List<ContinuousPlan> ContinuousPlanList { get; set; }

        /// <summary>
        /// 险别内容 （新增必填）
        /// </summary>
        [XmlArray("coverage_list")]
        [XmlArrayItem("coverage")]
        public List<Coverage> CoverageList { get; set; }

        /// <summary>
        /// 货币类型，枚举值 （新增必填）
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 保单终止时间  YYYY-MM-DD HH:MM:SS （新增必填）
        /// </summary>
        [XmlElement("effect_end_time")]
        public string EffectEndTime { get; set; }

        /// <summary>
        /// 保单生效时间  YYYY-MM-DD HH:MM:SS （新增必填）
        /// </summary>
        [XmlElement("effect_start_time")]
        public string EffectStartTime { get; set; }

        /// <summary>
        /// 电子保单 （新增必填）
        /// </summary>
        [XmlElement("electronic_policy_url")]
        public string ElectronicPolicyUrl { get; set; }

        /// <summary>
        /// 首期应收保费 单位：币种标准单位，如：人民币-元（保留2位小数） （新增必填）
        /// </summary>
        [XmlElement("first_premium")]
        public string FirstPremium { get; set; }

        /// <summary>
        /// 投保时间 YYYY-MM-DD HH:MM:SS （新增必填）
        /// </summary>
        [XmlElement("insured_time")]
        public string InsuredTime { get; set; }

        /// <summary>
        /// 出单时间  YYYY-MM-DD HH:MM:SS （新增必填）
        /// </summary>
        [XmlElement("issue_time")]
        public string IssueTime { get; set; }

        /// <summary>
        /// 续保时需传
        /// </summary>
        [XmlElement("old_policy_no")]
        public string OldPolicyNo { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付时间  YYYY-MM-DD HH:MM:SS （新增必填）
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 交易流水号 （新增必填）
        /// </summary>
        [XmlElement("pay_trade_no")]
        public string PayTradeNo { get; set; }

        /// <summary>
        /// 投被保人的信息必传 更新干系人信息场景下：干系人全量信息必传
        /// </summary>
        [XmlArray("person_list")]
        [XmlArrayItem("related_person")]
        public List<RelatedPerson> PersonList { get; set; }

        /// <summary>
        /// 保单号【用户ID-保司类型-保单号】保持唯一，修改场景此类字段必传
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 保单类型（不填写默认健康险）
        /// </summary>
        [XmlElement("policy_type")]
        public string PolicyType { get; set; }

        /// <summary>
        /// 分期保费 单位：币种标准单位，如：人民币-元（保留2位小数） （新增必填）
        /// </summary>
        [XmlElement("premium")]
        public string Premium { get; set; }

        /// <summary>
        /// 产品名称 （新增必填）
        /// </summary>
        [XmlElement("prod_name")]
        public string ProdName { get; set; }

        /// <summary>
        /// 产品编号 （新增必填）
        /// </summary>
        [XmlElement("prod_no")]
        public string ProdNo { get; set; }

        /// <summary>
        /// 保单的产品方案代码
        /// </summary>
        [XmlElement("product_scheme_code")]
        public string ProductSchemeCode { get; set; }

        /// <summary>
        /// 加油包场景会有主子保单
        /// </summary>
        [XmlElement("source_policy_no")]
        public string SourcePolicyNo { get; set; }

        /// <summary>
        /// 保单状态，枚举值 （新增必填）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 总保额  单位：币种标准单位，如：人民币-元（保留2位小数
        /// </summary>
        [XmlElement("sum_insured")]
        public string SumInsured { get; set; }

        /// <summary>
        /// 退保金额 单位：元（保留2位小数）
        /// </summary>
        [XmlElement("surrender_amount")]
        public string SurrenderAmount { get; set; }

        /// <summary>
        /// 按照：「退保类型-退保原因」的格式
        /// </summary>
        [XmlElement("surrender_reason")]
        public string SurrenderReason { get; set; }

        /// <summary>
        /// 退保时间 YYYY-MM-DD HH:MM:SS
        /// </summary>
        [XmlElement("surrender_time")]
        public string SurrenderTime { get; set; }

        /// <summary>
        /// 中止原因文本描述
        /// </summary>
        [XmlElement("suspended_reason")]
        public string SuspendedReason { get; set; }

        /// <summary>
        /// 中止时间 YYYY-MM-DD HH:MM:SS
        /// </summary>
        [XmlElement("suspended_time")]
        public string SuspendedTime { get; set; }

        /// <summary>
        /// 实收总保费 单位：币种标准单位，如：人民币-元（保留2位小数） （新增必填）
        /// </summary>
        [XmlElement("total_premium")]
        public string TotalPremium { get; set; }

        /// <summary>
        /// 支付宝用户Id。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
