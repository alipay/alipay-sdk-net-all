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
        /// 群ID（冗余字段，可忽略，参考group_instance_id）
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 群id
        /// </summary>
        [XmlElement("group_instance_id")]
        public string GroupInstanceId { get; set; }

        /// <summary>
        /// 定义群组分类，便于后台管理运营识别，可与下面设置的群名称保持一致；例：xx门店群，内部测试群
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 群组id
        /// </summary>
        [XmlElement("group_oid")]
        public string GroupOid { get; set; }

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
