using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupMsgSendRecordVO Data Structure.
    /// </summary>
    [Serializable]
    public class GroupMsgSendRecordVO : AopObject
    {
        /// <summary>
        /// 群组id，表里唯一键，创建群组自动生成
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 定义群组分类，便于后台管理运营识别，可与下面设置的群名称保持一致；例：xx门店群，内部测试群
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 群组下群实例发送详情列表
        /// </summary>
        [XmlArray("send_detail_list")]
        [XmlArrayItem("group_instance_msg_send_detail_v_o")]
        public List<GroupInstanceMsgSendDetailVO> SendDetailList { get; set; }
    }
}
