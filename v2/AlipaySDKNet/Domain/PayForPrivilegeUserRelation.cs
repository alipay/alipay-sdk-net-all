using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PayForPrivilegeUserRelation Data Structure.
    /// </summary>
    [Serializable]
    public class PayForPrivilegeUserRelation : AopObject
    {
        /// <summary>
        /// 关系建立时间
        /// </summary>
        [XmlElement("join_time")]
        public string JoinTime { get; set; }

        /// <summary>
        /// 关系解除时间，如果当前关系已解除该字段一定存在
        /// </summary>
        [XmlElement("leave_time")]
        public string LeaveTime { get; set; }

        /// <summary>
        /// 充享惠业务用户与商户关系ID
        /// </summary>
        [XmlElement("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 会员所属商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 当前关系状态，VALID(有效), DELETED(删除)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
