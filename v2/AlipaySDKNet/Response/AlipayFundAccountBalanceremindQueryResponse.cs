using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundAccountBalanceremindQueryResponse.
    /// </summary>
    public class AlipayFundAccountBalanceremindQueryResponse : AopResponse
    {
        /// <summary>
        /// 单位：元，当设置了触发余额提醒的上限阈值时返回该值，余额大于该值时按规则发送余额提醒通知
        /// </summary>
        [XmlElement("max_remind_balance")]
        public string MaxRemindBalance { get; set; }

        /// <summary>
        /// 单位：元，当设置了触发余额提醒的下限阈值时返回该值，余额小于该值时按规则发送余额提醒通知
        /// </summary>
        [XmlElement("min_remind_balance")]
        public string MinRemindBalance { get; set; }

        /// <summary>
        /// 被监控账户
        /// </summary>
        [XmlElement("monitor_user_id")]
        public string MonitorUserId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("monitor_user_open_id")]
        public string MonitorUserOpenId { get; set; }

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
        /// 计划版本号
        /// </summary>
        [XmlElement("plan_version")]
        public string PlanVersion { get; set; }

        /// <summary>
        /// 被监控账户信息
        /// </summary>
        [XmlElement("remind_account_info")]
        public AccountModelDTO RemindAccountInfo { get; set; }

        /// <summary>
        /// 提醒人列表
        /// </summary>
        [XmlArray("remind_person_list")]
        [XmlArrayItem("remind_person_info_d_t_o")]
        public List<RemindPersonInfoDTO> RemindPersonList { get; set; }

        /// <summary>
        /// 通知发送调度信息
        /// </summary>
        [XmlArray("schedule_info_list")]
        [XmlArrayItem("schedule_info_d_t_o")]
        public List<ScheduleInfoDTO> ScheduleInfoList { get; set; }

        /// <summary>
        /// 计划状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 接入方的业务场景，如示例值：ETC代扣场景
        /// </summary>
        [XmlElement("third_biz_scene")]
        public string ThirdBizScene { get; set; }
    }
}
