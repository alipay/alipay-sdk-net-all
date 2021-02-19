using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JointAccountMemberList Data Structure.
    /// </summary>
    [Serializable]
    public class JointAccountMemberList : AopObject
    {
        /// <summary>
        /// 额度模型
        /// </summary>
        [XmlArray("account_quota")]
        [XmlArrayItem("joint_account_quota_d_t_o")]
        public List<JointAccountQuotaDTO> AccountQuota { get; set; }

        /// <summary>
        /// 成员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
