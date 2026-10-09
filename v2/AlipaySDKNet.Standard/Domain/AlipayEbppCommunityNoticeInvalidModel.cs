using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppCommunityNoticeInvalidModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppCommunityNoticeInvalidModel : AopObject
    {
        /// <summary>
        /// 支付宝通知公告id
        /// </summary>
        [XmlElement("alipay_notice_id")]
        public string AlipayNoticeId { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 支付宝小区编码，由支付宝分配
        /// </summary>
        [XmlElement("community_short_name")]
        public string CommunityShortName { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部小区id
        /// </summary>
        [XmlElement("out_community_id")]
        public string OutCommunityId { get; set; }
    }
}
