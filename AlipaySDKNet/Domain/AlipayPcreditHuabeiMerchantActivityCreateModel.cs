using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiMerchantActivityCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiMerchantActivityCreateModel : AopObject
    {
        /// <summary>
        /// 花呗分期商家贴息活动名称，长度不能超过30个汉字或字符
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 花呗分期贴息预算金额，单位是元
        /// </summary>
        [XmlElement("amount_budget")]
        public string AmountBudget { get; set; }

        /// <summary>
        /// 预算提醒邮件列表，邮箱必须符合邮箱地址规则，提醒邮箱个数不能超过5个,多个邮箱用逗号隔开
        /// </summary>
        [XmlElement("budget_warning_mail_list")]
        public string BudgetWarningMailList { get; set; }

        /// <summary>
        /// 预算提醒手机号列表，符合手机号码规则，提醒手机号个数不能超过5个，多个手机号用逗号隔开
        /// </summary>
        [XmlElement("budget_warning_mobile_list")]
        public string BudgetWarningMobileList { get; set; }

        /// <summary>
        /// 预算提醒金额，不能高于预算金额，预算达到该金额时会触发告警通知，单位是元
        /// </summary>
        [XmlElement("budget_warning_money")]
        public string BudgetWarningMoney { get; set; }

        /// <summary>
        /// 活动结束时间，必须大于start_time，且结束时间必须大于当前时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 出资的资金类型，默认值=MONEY，商户积分=MERCHANT_POINT
        /// </summary>
        [XmlElement("fund_type")]
        public string FundType { get; set; }

        /// <summary>
        /// 花呗分期数集合
        /// </summary>
        [XmlArray("install_num_list")]
        [XmlArrayItem("number")]
        public List<long> InstallNumList { get; set; }

        /// <summary>
        /// 免息金额上限不能大于300000, 不能低于免息金额下限，交易额度若高于该上限值则不做花呗分期免息补贴，单位是元
        /// </summary>
        [XmlElement("max_money_limit")]
        public string MaxMoneyLimit { get; set; }

        /// <summary>
        /// 贴息对象门店信息
        /// </summary>
        [XmlArray("merchant_info")]
        [XmlArrayItem("hb_merchant_info")]
        public List<HbMerchantInfo> MerchantInfo { get; set; }

        /// <summary>
        /// 免息金额下限不能少于100，交易额度若小于该值，则不做花呗分期免息补贴，单位是元。
        /// </summary>
        [XmlElement("min_money_limit")]
        public string MinMoneyLimit { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 活动开始时间,精确到秒
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
