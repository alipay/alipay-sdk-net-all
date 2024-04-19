using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignUnitedopencouponConfigQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignUnitedopencouponConfigQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否绑定手机号。（只有活动规则上配置要求绑定手机号且当前用户未绑定手机号情况下该字段才会返回false，其余情况下不返回或者返回为空（null）
        /// </summary>
        [XmlElement("bind_phone")]
        public bool BindPhone { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("camp_end_time")]
        public string CampEndTime { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [XmlElement("camp_start_time")]
        public string CampStartTime { get; set; }

        /// <summary>
        /// 活动状态
        /// </summary>
        [XmlElement("camp_status")]
        public string CampStatus { get; set; }

        /// <summary>
        /// 是否已经领取过
        /// </summary>
        [XmlElement("has_receive")]
        public bool HasReceive { get; set; }

        /// <summary>
        /// 用户支付宝登录号（脱敏）
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 有预算情况下是否必中奖，即区分抽奖模式还是领奖模式 true为抽奖模式（有预算情况下不是必中奖），false为领奖模式（有预算情况下必中奖）
        /// </summary>
        [XmlElement("lottery_mode")]
        public bool LotteryMode { get; set; }

        /// <summary>
        /// 是否实名认证（只有活动规则上配置需要验证实名，且当前用户不满足该规则时才会返回false，其余情况默认不返回或者返回为null）
        /// </summary>
        [XmlElement("real_name_auth")]
        public bool RealNameAuth { get; set; }

        /// <summary>
        /// 是否剩余预算
        /// </summary>
        [XmlElement("remain_budget")]
        public bool RemainBudget { get; set; }

        /// <summary>
        /// 是否是风险用户
        /// </summary>
        [XmlElement("risk_user")]
        public bool RiskUser { get; set; }

        /// <summary>
        /// 今日是否已领取过
        /// </summary>
        [XmlElement("today_has_receive")]
        public bool TodayHasReceive { get; set; }

        /// <summary>
        /// 券配置信息列表
        /// </summary>
        [XmlElement("voucher_digests")]
        public UnitedVoucherDigest VoucherDigests { get; set; }

        /// <summary>
        /// 用户支付宝账号(UID)维度的中奖计次信息
        /// </summary>
        [XmlElement("win_count_info")]
        public UnitedCountInfo WinCountInfo { get; set; }

        /// <summary>
        /// 支付宝账号(UID)维度是否可领奖
        /// </summary>
        [XmlElement("win_enable")]
        public bool WinEnable { get; set; }
    }
}
