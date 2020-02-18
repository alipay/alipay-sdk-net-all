using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialBaseGroupQueryResponse.
    /// </summary>
    public class AlipaySocialBaseGroupQueryResponse : AopResponse
    {
        /// <summary>
        /// 群id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 群的群成员总数
        /// </summary>
        [XmlElement("group_member_count")]
        public long GroupMemberCount { get; set; }

        /// <summary>
        /// 群成员列表
        /// </summary>
        [XmlArray("group_members")]
        [XmlArrayItem("group_member_info")]
        public List<GroupMemberInfo> GroupMembers { get; set; }

        /// <summary>
        /// 群的名称
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }
    }
}
