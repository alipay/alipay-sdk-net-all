using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryRecruitEmployerAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryRecruitEmployerAddModel : AopObject
    {
        /// <summary>
        /// 雇主是否通过快招渠道在服务商侧新注册，true=通过快招渠道新注册用户，false=非快招渠道注册的用户
        /// </summary>
        [XmlElement("new_register")]
        public bool NewRegister { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 雇主在服务商侧的主键id
        /// </summary>
        [XmlElement("out_hire_user_id")]
        public string OutHireUserId { get; set; }

        /// <summary>
        /// 雇主在服务商侧的注册时间
        /// </summary>
        [XmlElement("register_time")]
        public string RegisterTime { get; set; }

        /// <summary>
        /// 是否在服务商侧已完成发布岗位，true=已完成，false=未完成
        /// </summary>
        [XmlElement("release_job")]
        public bool ReleaseJob { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
