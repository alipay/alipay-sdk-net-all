using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupInstanceMsgSendDetailVO Data Structure.
    /// </summary>
    [Serializable]
    public class GroupInstanceMsgSendDetailVO : AopObject
    {
        /// <summary>
        /// 群id
        /// </summary>
        [XmlElement("group_instance_id")]
        public string GroupInstanceId { get; set; }

        /// <summary>
        /// 用户在支付宝APP可见的群名称，自动建群时会使用“该名称+X群”来命名，无需手动输入群号。建议以品牌名称+分类方式命名，请勿添加数字。
        /// </summary>
        [XmlElement("group_instance_name")]
        public string GroupInstanceName { get; set; }

        /// <summary>
        /// chat侧群消息发送记录id
        /// </summary>
        [XmlElement("group_instance_record_id")]
        public string GroupInstanceRecordId { get; set; }

        /// <summary>
        /// 消息发送时间
        /// </summary>
        [XmlElement("send_time")]
        public string SendTime { get; set; }

        /// <summary>
        /// 发送状态， 2:待发送, 3: 发送中, 4: 发送成功, 5: 发送失败, 6: 部分失败, 7: 重发, 8: 待撤回, 9: 撤回中, 10: 已撤回, 12: 部分撤回, 13: 部分成功, 14: 部分删除, 15: 部分发送中
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 状态描述
        /// </summary>
        [XmlElement("tips")]
        public string Tips { get; set; }
    }
}
