using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserDtbankcustActivityconfigQueryResponse.
    /// </summary>
    public class AlipayUserDtbankcustActivityconfigQueryResponse : AopResponse
    {
        /// <summary>
        /// 当入参活动类型是DISCOUNT、VOUCHER、FIRST_BIND_CARD_GIFT时返回活动ID； 当入参活动类型是SOLUTION时返回解决方案ID
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动状态
        /// </summary>
        [XmlElement("activity_status")]
        public string ActivityStatus { get; set; }

        /// <summary>
        /// 活动时间信息
        /// </summary>
        [XmlElement("activity_time_info")]
        public DtBankActivityTimeInfo ActivityTimeInfo { get; set; }

        /// <summary>
        /// 活动类型信息
        /// </summary>
        [XmlElement("activity_type_info")]
        public DtBankActivityTypeInfo ActivityTypeInfo { get; set; }

        /// <summary>
        /// 预算预警信息 为空时表示不进行预算预警， 不为空时表示有预算预警，返回预算预警配置
        /// </summary>
        [XmlElement("alert_config_info")]
        public DtbankActivityAlertConfigInfo AlertConfigInfo { get; set; }

        /// <summary>
        /// 活动配置银行信息
        /// </summary>
        [XmlElement("bank_info")]
        public DtBankInfo BankInfo { get; set; }

        /// <summary>
        /// 活动预算信息
        /// </summary>
        [XmlElement("budget_info")]
        public DtBankBudgetInfo BudgetInfo { get; set; }

        /// <summary>
        /// 计次信息
        /// </summary>
        [XmlElement("count_limit")]
        public string CountLimit { get; set; }

        /// <summary>
        /// 活动配置人群信息
        /// </summary>
        [XmlElement("crowd_info")]
        public DtBankCrowdInfo CrowdInfo { get; set; }

        /// <summary>
        /// 活动效果数据，一般情况下数据更新到昨日，具体以接口中返回的更新日期为准。
        /// </summary>
        [XmlElement("data_effect_info")]
        public DtbankActivityDataEffectInfo DataEffectInfo { get; set; }

        /// <summary>
        /// 优惠类型信息
        /// </summary>
        [XmlElement("preference_type_info")]
        public DtBankPreferenceTypeInfo PreferenceTypeInfo { get; set; }

        /// <summary>
        /// 活动支持的核销使用场景。数据格式为：场景1,场景2-子场景1/子场景2,场景3。例如：天猫超市,生活缴费-水费/电费,饿了么
        /// </summary>
        [XmlElement("use_scene")]
        public string UseScene { get; set; }

        /// <summary>
        /// 活动配置对应的模板id信息
        /// </summary>
        [XmlElement("voucher_template_id")]
        public string VoucherTemplateId { get; set; }

        /// <summary>
        /// 当前活动的白名单信息，逗号分隔
        /// </summary>
        [XmlElement("white_list_info")]
        public string WhiteListInfo { get; set; }
    }
}
