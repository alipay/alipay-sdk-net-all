using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceNxactivityQueryResponse.
    /// </summary>
    public class AlipayCommerceNxactivityQueryResponse : AopResponse
    {
        /// <summary>
        /// 活动状态
        /// </summary>
        [XmlElement("act_status")]
        public string ActStatus { get; set; }

        /// <summary>
        /// 活动类型
        /// </summary>
        [XmlElement("act_type")]
        public string ActType { get; set; }

        /// <summary>
        /// 活动规则详情
        /// </summary>
        [XmlElement("activity_rule_detail")]
        public string ActivityRuleDetail { get; set; }

        /// <summary>
        /// 卡片logo
        /// </summary>
        [XmlElement("card_logo")]
        public string CardLogo { get; set; }

        /// <summary>
        /// 卡片文案
        /// </summary>
        [XmlElement("card_text")]
        public string CardText { get; set; }

        /// <summary>
        /// 卡片标题
        /// </summary>
        [XmlElement("card_title")]
        public string CardTitle { get; set; }

        /// <summary>
        /// 当前活动进度，单位由progress_unit字段指定。
        /// </summary>
        [XmlElement("current_progress")]
        public string CurrentProgress { get; set; }

        /// <summary>
        /// 任务截止时间戳，单位为毫秒。
        /// </summary>
        [XmlElement("gmt_expired")]
        public long GmtExpired { get; set; }

        /// <summary>
        /// 任务开始时间戳，单位为毫秒。
        /// </summary>
        [XmlElement("gmt_start")]
        public long GmtStart { get; set; }

        /// <summary>
        /// 主奖品图片
        /// </summary>
        [XmlElement("main_prize_image")]
        public string MainPrizeImage { get; set; }

        /// <summary>
        /// 主标题
        /// </summary>
        [XmlElement("main_title")]
        public string MainTitle { get; set; }

        /// <summary>
        /// 进度单位
        /// </summary>
        [XmlElement("progress_unit")]
        public string ProgressUnit { get; set; }

        /// <summary>
        /// 活动总进度，单位由progress_unit字段指定。
        /// </summary>
        [XmlElement("total_progress")]
        public string TotalProgress { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("voucher_list")]
        [XmlArrayItem("nx_activity_voucher_info")]
        public List<NxActivityVoucherInfo> VoucherList { get; set; }
    }
}
