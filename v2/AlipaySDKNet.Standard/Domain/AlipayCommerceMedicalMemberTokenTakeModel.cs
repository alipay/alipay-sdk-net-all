using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMemberTokenTakeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMemberTokenTakeModel : AopObject
    {
        /// <summary>
        /// 周期 有效期 多少天
        /// </summary>
        [XmlElement("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 业务来源类型
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
