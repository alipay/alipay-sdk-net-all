using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppCommunityUsertagSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppCommunityUsertagSyncModel : AopObject
    {
        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 认证状态- NO_AUDIT：未审核 AUDITED：已审核 AUDIT_FAIL：未通过审核 AUDITING：审核中
        /// </summary>
        [XmlElement("audit_status")]
        public string AuditStatus { get; set; }

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

        /// <summary>
        /// 外部用户id
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 用户身份标签- OWNER：业主 FAMILY：家属 TENANT：租客 FRIEND：朋友
        /// </summary>
        [XmlElement("user_tag")]
        public string UserTag { get; set; }
    }
}
