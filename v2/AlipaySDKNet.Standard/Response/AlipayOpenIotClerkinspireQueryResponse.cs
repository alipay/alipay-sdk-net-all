using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotClerkinspireQueryResponse.
    /// </summary>
    public class AlipayOpenIotClerkinspireQueryResponse : AopResponse
    {
        /// <summary>
        /// 时间毫秒数
        /// </summary>
        [XmlElement("begin_time")]
        public string BeginTime { get; set; }

        /// <summary>
        /// 单收银员每日最多同时打卡设备数
        /// </summary>
        [XmlElement("checkin_device_limit")]
        public string CheckinDeviceLimit { get; set; }

        /// <summary>
        /// 单设备每日最多打卡人数
        /// </summary>
        [XmlElement("clerk_limit")]
        public string ClerkLimit { get; set; }

        /// <summary>
        /// 日激励笔数上线
        /// </summary>
        [XmlElement("daily_max_trade_threshold")]
        public string DailyMaxTradeThreshold { get; set; }

        /// <summary>
        /// 时间毫秒数
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 未报名：UN_SIGN_UP  、已报名，未打卡：UN_CHECK_IN  、已打卡：CHECKED_IN
        /// </summary>
        [XmlElement("join_status")]
        public string JoinStatus { get; set; }

        /// <summary>
        /// 单笔返奖金额
        /// </summary>
        [XmlElement("single_reward_amount")]
        public string SingleRewardAmount { get; set; }

        /// <summary>
        /// 交易门槛数
        /// </summary>
        [XmlElement("trade_threshold")]
        public string TradeThreshold { get; set; }
    }
}
