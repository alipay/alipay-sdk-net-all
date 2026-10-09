using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupMsgSendDetailVO Data Structure.
    /// </summary>
    [Serializable]
    public class GroupMsgSendDetailVO : AopObject
    {
        /// <summary>
        /// 消息详情
        /// </summary>
        [XmlElement("msg_detail")]
        public GroupMsgDetailVO MsgDetail { get; set; }

        /// <summary>
        /// 发送记录列表
        /// </summary>
        [XmlArray("send_record_list")]
        [XmlArrayItem("group_msg_send_record_v_o")]
        public List<GroupMsgSendRecordVO> SendRecordList { get; set; }
    }
}
