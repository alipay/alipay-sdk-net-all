using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundAccountBalanceremindModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundAccountBalanceremindModifyModel : AopObject
    {
        /// <summary>
        /// 场景码，固定传：MODIFY_PLAN
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 单位：元，触发余额提醒的上限阈值，当需要设置余额大于某值触发通知时设置改字段，设置后余额大于该值时按规则发送余额提醒通知
        /// </summary>
        [XmlElement("max_remind_balance")]
        public string MaxRemindBalance { get; set; }

        /// <summary>
        /// 单位：元，触发余额提醒的下限阈值，当需要设置下限时填充此字段，设置后余额小于该值时按规则发送余额提醒通知
        /// </summary>
        [XmlElement("min_remind_balance")]
        public string MinRemindBalance { get; set; }

        /// <summary>
        /// 被监管账户
        /// </summary>
        [XmlElement("monitor_user_id")]
        public string MonitorUserId { get; set; }

        /// <summary>
        /// 被监管账户
        /// </summary>
        [XmlElement("monitor_user_openid")]
        public string MonitorUserOpenid { get; set; }

        /// <summary>
        /// 计划id
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 余额提醒计划的名称，在支付宝端内暂未对客展示，为空时会自动填充一个默认值
        /// </summary>
        [XmlElement("plan_name")]
        public string PlanName { get; set; }

        /// <summary>
        /// 计划版本
        /// </summary>
        [XmlElement("plan_version")]
        public string PlanVersion { get; set; }

        /// <summary>
        /// 产品码，固定传：BALANCE_REMIND
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 提醒人信息列表
        /// </summary>
        [XmlArray("remind_person_list")]
        [XmlArrayItem("remind_person_info_d_t_o")]
        public List<RemindPersonInfoDTO> RemindPersonList { get; set; }

        /// <summary>
        /// 提醒人信息列表
        /// </summary>
        [XmlArray("schedule_info_list")]
        [XmlArrayItem("schedule_info_d_t_o")]
        public List<ScheduleInfoDTO> ScheduleInfoList { get; set; }

        /// <summary>
        /// 接入方的业务场景，如示例值：ETC代扣场景
        /// </summary>
        [XmlElement("third_biz_scene")]
        public string ThirdBizScene { get; set; }
    }
}
