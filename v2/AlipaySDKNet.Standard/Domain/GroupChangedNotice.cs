using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupChangedNotice Data Structure.
    /// </summary>
    [Serializable]
    public class GroupChangedNotice : AopObject
    {
        /// <summary>
        /// 消息创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 群ID
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 当是成员入群或退群时有值。表示成员变更数量
        /// </summary>
        [XmlElement("mem_change_cnt")]
        public long MemChangeCnt { get; set; }

        /// <summary>
        /// 当是成员入群或退群时有值。变更的成员列表
        /// </summary>
        [XmlArray("mem_change_list")]
        [XmlArrayItem("group_member_detail")]
        public List<GroupMemberDetail> MemChangeList { get; set; }

        /// <summary>
        /// 商家pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 变更信息。成员入群: add_member，成员退群: del_member，群名变更: change_name
        /// </summary>
        [XmlElement("update_info")]
        public string UpdateInfo { get; set; }
    }
}
