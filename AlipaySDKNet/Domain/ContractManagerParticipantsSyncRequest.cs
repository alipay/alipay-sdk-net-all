using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContractManagerParticipantsSyncRequest Data Structure.
    /// </summary>
    [Serializable]
    public class ContractManagerParticipantsSyncRequest : AopObject
    {
        /// <summary>
        /// 参与人名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 参与人主体名称
        /// </summary>
        [XmlElement("principal_name")]
        public string PrincipalName { get; set; }

        /// <summary>
        /// 参与人主体类型：1-个人,2-企业
        /// </summary>
        [XmlElement("principal_type")]
        public string PrincipalType { get; set; }

        /// <summary>
        /// 用户角色, 1-发起人,2-签署人,3-抄送人
        /// </summary>
        [XmlElement("role")]
        public string Role { get; set; }

        /// <summary>
        /// 签署状态, 0-待签, 1-未签, 2-已签 3-待审批 4-拒签 5-无需签署
        /// </summary>
        [XmlElement("sign_status")]
        public string SignStatus { get; set; }

        /// <summary>
        /// 签署时间
        /// </summary>
        [XmlElement("sign_time")]
        public string SignTime { get; set; }

        /// <summary>
        /// 支付宝账号Id,数组关联多个支付宝账号 （如果未注册支付宝账号 则为空）
        /// </summary>
        [XmlArray("user_ids")]
        [XmlArrayItem("string")]
        public List<string> UserIds { get; set; }
    }
}
