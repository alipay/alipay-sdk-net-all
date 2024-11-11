using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasOpenIndrreferralCreateResponse.
    /// </summary>
    public class AlipayOverseasOpenIndrreferralCreateResponse : AopResponse
    {
        /// <summary>
        /// 推荐码过期时间，超期之后用户仍然可以点击链接跳转，但不会记录推荐关系
        /// </summary>
        [XmlElement("expired_time")]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// 推荐跳转链接
        /// </summary>
        [XmlElement("jump_link")]
        public string JumpLink { get; set; }

        /// <summary>
        /// 生成的推荐码
        /// </summary>
        [XmlElement("referral_code")]
        public string ReferralCode { get; set; }

        /// <summary>
        /// 请求结果，代表本次调用是否成功
        /// </summary>
        [XmlElement("result")]
        public IndrISVResult Result { get; set; }
    }
}
