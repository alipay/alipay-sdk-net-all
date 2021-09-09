using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MemberCardCreatePrepaidPromotionPlanInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MemberCardCreatePrepaidPromotionPlanInfo : AopObject
    {
        /// <summary>
        /// 充值方案权益金部分，最小为0，权益金不超过5000元
        /// </summary>
        [XmlElement("benefit")]
        public string Benefit { get; set; }

        /// <summary>
        /// 方案的失效时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 充值本金部分，单位元，必须大于0，本金不超过5000元
        /// </summary>
        [XmlElement("principal")]
        public string Principal { get; set; }

        /// <summary>
        /// 方案开始生效时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// ENALBLE生效；DISABLE失效
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
