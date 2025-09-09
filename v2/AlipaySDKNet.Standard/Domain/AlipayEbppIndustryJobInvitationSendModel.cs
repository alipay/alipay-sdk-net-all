using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryJobInvitationSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryJobInvitationSendModel : AopObject
    {
        /// <summary>
        /// 邀约描述
        /// </summary>
        [XmlElement("invite_text")]
        public string InviteText { get; set; }

        /// <summary>
        /// 用户求职意向列表
        /// </summary>
        [XmlArray("job_intention_list")]
        [XmlArrayItem("job_intention_detail")]
        public List<JobIntentionDetail> JobIntentionList { get; set; }

        /// <summary>
        /// 用户手机号对称加密字符串，加密方式请与相关技术或业务同学了解
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 外部邀约id是表示当前邀约请求的唯一业务单据号
        /// </summary>
        [XmlElement("out_invitation_id")]
        public string OutInvitationId { get; set; }

        /// <summary>
        /// 服务商的岗位id
        /// </summary>
        [XmlElement("out_job_id")]
        public string OutJobId { get; set; }
    }
}
