using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupMsgRecordVO Data Structure.
    /// </summary>
    [Serializable]
    public class GroupMsgRecordVO : AopObject
    {
        /// <summary>
        /// 业务自己定义的业务id
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 群组id列表
        /// </summary>
        [XmlArray("group_ids")]
        [XmlArrayItem("string")]
        public List<string> GroupIds { get; set; }

        /// <summary>
        /// 消息id
        /// </summary>
        [XmlElement("msg_id")]
        public string MsgId { get; set; }

        /// <summary>
        /// 群消息类型枚举，小程序消息:"APP"，图片消息:"IMAGE"，链接消息:"LINK"，纯文本消息:"TEXT"
        /// </summary>
        [XmlElement("msg_type")]
        public string MsgType { get; set; }

        /// <summary>
        /// 发送状态， 2:待发送,  3: 发送中,  4: 发送成功,  5: 发送失败,  6: 部分失败,  7: 重发,  8: 待撤回,  9: 撤回中,  10: 已撤回,  12: 部分撤回,  13: 部分成功,  14: 部分删除,  15: 部分发送中
        /// </summary>
        [XmlElement("send_status")]
        public long SendStatus { get; set; }

        /// <summary>
        /// 消息发送时间
        /// </summary>
        [XmlElement("send_time")]
        public string SendTime { get; set; }

        /// <summary>
        /// 消息所属标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
