using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneMarketingEquitystatusThirdpartModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneMarketingEquitystatusThirdpartModifyModel : AopObject
    {
        /// <summary>
        /// 第三方权益码
        /// </summary>
        [XmlElement("equity_code")]
        public string EquityCode { get; set; }

        /// <summary>
        /// 第三方权益信息
        /// </summary>
        [XmlElement("equity_info")]
        public FinEquityInfo EquityInfo { get; set; }

        /// <summary>
        /// 外部业务号，每个用户每次领取动作会生成的唯一发放号，商户可用该字段做幂等标识
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 来源，每个接入的第三方都会有一个来源号
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 状态：USED-已使用；EXPIRED-过期；REFUND-退单；INVALID-不可用；
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 权益更新的时间
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_info")]
        public FinUserInfo UserInfo { get; set; }
    }
}
