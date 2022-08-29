using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZMGOOpenConfig Data Structure.
    /// </summary>
    [Serializable]
    public class ZMGOOpenConfig : AopObject
    {
        /// <summary>
        /// 固定到期时间或每月的第几日。 （1）当period_mode为APPOINT_DATE时，取值固定日期，如"2022-06-01 00:00:00"，表示协议在6月1号0点到期; （2）当period_mode为FIX_DATE，取值"3"，表示协议在period_time个月后的3号到期。
        /// </summary>
        [XmlElement("appoint_date")]
        public string AppointDate { get; set; }

        /// <summary>
        /// 芝麻GO卡颜色。 C_BLACK("C_BLACK", "黑色"), C_RED("C_RED", "红色"), C_GREEN("C_GREEN", "绿色"), C_LIGHT_BLUE("C_LIGHT_BLUE", "浅蓝色"), C_BLUE("C_BLUE", "蓝色"), C_ORANGE("C_ORANGE","橙色"), C_PURPLE("C_PURPLE", "紫色");
        /// </summary>
        [XmlElement("card_color_scheme")]
        public string CardColorScheme { get; set; }

        /// <summary>
        /// 未完成任务规则详情
        /// </summary>
        [XmlElement("custom_open_tip_list")]
        public string CustomOpenTipList { get; set; }

        /// <summary>
        /// 规则详情
        /// </summary>
        [XmlElement("custom_open_tips")]
        public string CustomOpenTips { get; set; }

        /// <summary>
        /// 担保金额额度
        /// </summary>
        [XmlElement("freeze_amount")]
        public string FreezeAmount { get; set; }

        /// <summary>
        /// 用户签约间隔时间
        /// </summary>
        [XmlElement("min_sign_interval")]
        public string MinSignInterval { get; set; }

        /// <summary>
        /// 芝麻GO义务到期的计算方式。包括： RELATIVE_DATE("RELATIVE_DATE", "相对日期"), ABSOLATE_DATE("ABSOLATE_DATE", "绝对日期(当日开始计算)"), ABSOLUTE_PLUS_1_DATE("ABSOLUTE_PLUS_1_DATE", "绝对日期(次日开始计算)"), FIX_DATE("FIX_DATE", "固定日期"), APPOINT_DATE("APPOINT_DATE", "指定日期"),
        /// </summary>
        [XmlElement("period_mode")]
        public string PeriodMode { get; set; }

        /// <summary>
        /// 周期时长 当period_mode为RELATIVE_DATE、ABSOLATE_DATE、ABSOLUTE_PLUS_1_DATE、FIX_DATE时必填
        /// </summary>
        [XmlElement("period_time")]
        public string PeriodTime { get; set; }

        /// <summary>
        /// 是否支持延期特权
        /// </summary>
        [XmlElement("support_expire_deferral")]
        public bool SupportExpireDeferral { get; set; }
    }
}
