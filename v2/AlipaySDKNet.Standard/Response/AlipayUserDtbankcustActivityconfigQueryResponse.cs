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
        /// 活动ID
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
        /// 优惠类型信息
        /// </summary>
        [XmlElement("preference_type_info")]
        public DtBankPreferenceTypeInfo PreferenceTypeInfo { get; set; }

        /// <summary>
        /// 活动支持的核销使用场景。数据格式为：场景1,场景2-子场景1/子场景2,场景3。例如：天猫超市,生活缴费-水费/电费,饿了么
        /// </summary>
        [XmlElement("use_scene")]
        public string UseScene { get; set; }
    }
}
