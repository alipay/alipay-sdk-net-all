using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceExpenserulesSceneruleCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceExpenserulesSceneruleCreateModel : AopObject
    {
        /// <summary>
        /// 共同账号ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 有效期截止
        /// </summary>
        [XmlElement("effective_end_date")]
        public string EffectiveEndDate { get; set; }

        /// <summary>
        /// 有效期起始
        /// </summary>
        [XmlElement("effective_start_date")]
        public string EffectiveStartDate { get; set; }

        /// <summary>
        /// 切换open_id前请使用：员工支付宝uid列表 特殊说明：单次传入的最大员工数为50，后续通过修改费控规则员工接口进行员工调整
        /// </summary>
        [XmlArray("employee_list")]
        [XmlArrayItem("string")]
        public List<string> EmployeeList { get; set; }

        /// <summary>
        /// 切换open_id后请使用：员工open_id/企业码员工ID列表 特殊说明：单次传入的最大员工数为50，后续通过修改费控规则员工接口进行员工调整
        /// </summary>
        [XmlArray("employee_open_id_list")]
        [XmlArrayItem("string")]
        public List<string> EmployeeOpenIdList { get; set; }

        /// <summary>
        /// 企业码企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 费控条件列表 特殊说明： 1）至少存在日额度（QUOTA_DAY）、月额度（QUOTA_MONTH）、有效期总额度（QUOTA_TOTAL）三者中的一个额度条件； 2）如果费用类型为MEAL，费控维度商户（MEAL_MERCHANT）和商户类型（MCC）对应的费控条件必须存在其一且不能同时存在； 3）如果费用类型为METRO，费控维度地铁卡类型（CARD_TYPE）对应的费控条件必须存在； 4）如果因公场景为OVERTIME，费控维度时间段（ALARM_CLOCK_TIME）对应的费控条件必须存在； 5）不能存在重复的费控维度对应的费控条件； 6）非MEAL费用类型，商户仅支持MERCHANT，不支持MEAL_MERCHANT
        /// </summary>
        [XmlArray("expense_ctrl_rule_info_list")]
        [XmlArrayItem("expense_ctr_rule_info")]
        public List<ExpenseCtrRuleInfo> ExpenseCtrlRuleInfoList { get; set; }

        /// <summary>
        /// 费用类型 枚举值：MEAL（餐饮），METRO（地铁）
        /// </summary>
        [XmlElement("expense_type")]
        public string ExpenseType { get; set; }

        /// <summary>
        /// 当笔消费金额大于规则可用余额时，用于控制支付策略，该字段缺省时采取因公账户和个人账户组合支付策略， 枚举值：PERSONAL（全部个人账户支付）, COMBINATION（因公账户和个人账户组合支付）
        /// </summary>
        [XmlElement("payment_policy")]
        public string PaymentPolicy { get; set; }

        /// <summary>
        /// 因公场景 枚举值：OVERTIME（加班），SUBSIDY（补贴福利），TRAVEL（差旅）
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 费控规则说明 特殊说明：敏感词校验
        /// </summary>
        [XmlElement("standard_desc")]
        public string StandardDesc { get; set; }

        /// <summary>
        /// 费控规则名称 特殊说明： 1）敏感词校验 2）不能重复，若需要重复联系支持人员定向放开
        /// </summary>
        [XmlElement("standard_name")]
        public string StandardName { get; set; }
    }
}
