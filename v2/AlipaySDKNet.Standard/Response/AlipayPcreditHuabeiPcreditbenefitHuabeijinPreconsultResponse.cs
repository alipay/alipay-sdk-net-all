using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditbenefitHuabeijinPreconsultResponse.
    /// </summary>
    public class AlipayPcreditHuabeiPcreditbenefitHuabeijinPreconsultResponse : AopResponse
    {
        /// <summary>
        /// 包含了花呗金反活动信息，如活动id，开始时间结束时间，反花呗金比例等
        /// </summary>
        [XmlElement("activity_info")]
        public HbmtActivityInfoVO ActivityInfo { get; set; }

        /// <summary>
        /// already_triggered 表示该用户在当前活动中是否已经成功领取过奖品,true表示已经领取过，false反之
        /// </summary>
        [XmlElement("already_triggered")]
        public bool AlreadyTriggered { get; set; }

        /// <summary>
        /// 精确可得花呗金数量，而不是可得花呗金范围，123个花呗金为1.23元，单位为分
        /// </summary>
        [XmlElement("calculated_amount")]
        public long CalculatedAmount { get; set; }

        /// <summary>
        /// 校验当前商户是否可享受这个活动，如果校验不可以享受该活动，不会计算可得花呗金
        /// </summary>
        [XmlElement("can_participate")]
        public bool CanParticipate { get; set; }

        /// <summary>
        /// 用来说明该笔金额是否到达了单笔可反最大花呗金限制
        /// </summary>
        [XmlElement("cap_applied")]
        public bool CapApplied { get; set; }

        /// <summary>
        /// 不同的业务码表示在花呗侧业务处理过程中的不同状态
        /// </summary>
        [XmlElement("hb_biz_code")]
        public string HbBizCode { get; set; }

        /// <summary>
        /// 模糊查询用户可得花呗金区间上限，没有开启精确预估花呗金开关时查询得到的用户可得花呗金区间上限
        /// </summary>
        [XmlElement("max_calculated_amount")]
        public long MaxCalculatedAmount { get; set; }

        /// <summary>
        /// 传入了试算金额但是没有打开精确预估花呗金开关时返回可得花呗金的下限
        /// </summary>
        [XmlElement("min_calculated_amount")]
        public long MinCalculatedAmount { get; set; }
    }
}
