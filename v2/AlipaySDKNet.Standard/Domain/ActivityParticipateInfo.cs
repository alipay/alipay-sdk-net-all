using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityParticipateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityParticipateInfo : AopObject
    {
        /// <summary>
        /// 活动编码
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 是否可参与当前活动
        /// </summary>
        [XmlElement("admited")]
        public bool Admited { get; set; }

        /// <summary>
        /// 是否已报名当前活动
        /// </summary>
        [XmlElement("has_sign_up")]
        public bool HasSignUp { get; set; }
    }
}
