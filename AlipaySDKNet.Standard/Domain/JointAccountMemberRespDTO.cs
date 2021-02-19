using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JointAccountMemberRespDTO Data Structure.
    /// </summary>
    [Serializable]
    public class JointAccountMemberRespDTO : AopObject
    {
        /// <summary>
        /// 额度模型
        /// </summary>
        [XmlArray("account_quota")]
        [XmlArrayItem("joint_account_quota_d_t_o")]
        public List<JointAccountQuotaDTO> AccountQuota { get; set; }

        /// <summary>
        /// 成员支付宝登录号
        /// </summary>
        [XmlElement("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 员工当前状态：  邀请中（PROCESSING）、正常（NORMAL）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 用户支付宝会员号
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
