using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppEbppShareStatusSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppEbppShareStatusSetModel : AopObject
    {
        /// <summary>
        /// 主分享人支付宝openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 三方流程号
        /// </summary>
        [XmlElement("out_process_id")]
        public string OutProcessId { get; set; }

        /// <summary>
        /// 支付宝流水号
        /// </summary>
        [XmlElement("process_id")]
        public string ProcessId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("share_open_id")]
        public string ShareOpenId { get; set; }

        /// <summary>
        /// 被分享人支付宝UID
        /// </summary>
        [XmlElement("share_uid")]
        public string ShareUid { get; set; }

        /// <summary>
        /// 共享权益失效时间
        /// </summary>
        [XmlElement("share_user_benefit_expire")]
        public string ShareUserBenefitExpire { get; set; }

        /// <summary>
        /// 共享权益开始时间
        /// </summary>
        [XmlElement("share_user_benefit_start")]
        public string ShareUserBenefitStart { get; set; }

        /// <summary>
        /// 共享状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 主共享人支付宝UID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
