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
        /// 用于描述定时群发消息发送失败的原因包括校验异常或者是消息内容异常等信息, 一般与send_status一起判断, 当send_status不等于成功时, 可以查看该字段是否有校验错误信息
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 群组id列表
        /// </summary>
        [XmlArray("group_ids")]
        [XmlArrayItem("string")]
        public List<string> GroupIds { get; set; }

        /// <summary>
        /// 用于描述周期消息发送配置
        /// </summary>
        [XmlElement("group_msg_schedule_config")]
        public GroupMsgScheduleConfigVO GroupMsgScheduleConfig { get; set; }

        /// <summary>
        /// 消息id
        /// </summary>
        [XmlElement("msg_id")]
        public string MsgId { get; set; }

        /// <summary>
        /// 群消息类型枚举，小程序消息:"APP"，图片消息:"IMAGE"，链接消息:"LINK"，纯文本消息:"TEXT"，优惠券消息:"COUPON"，商品消息:GOODS。当发送消息类型为复合消息（send_batch为true时），返回结果为几种消息类型的组合，示例:["APP", "COUPON", "IMAGE"]
        /// </summary>
        [XmlElement("msg_type")]
        public string MsgType { get; set; }

        /// <summary>
        /// 描述发送的是单条消息还是复合消息
        /// </summary>
        [XmlElement("send_batch")]
        public bool SendBatch { get; set; }

        /// <summary>
        /// 发送状态， 2:待发送,  3: 发送中,  4: 发送成功,  5: 发送失败,  6: 部分失败,  7: 重发,  8: 待撤回,  9: 撤回中,  10: 已撤回,  12: 部分撤回,  13: 部分成功,  14: 部分删除,  15: 部分发送中
        /// </summary>
        [XmlElement("send_status")]
        public long SendStatus { get; set; }

        /// <summary>
        /// 发送策略支持0立即发送和1定时发送
        /// </summary>
        [XmlElement("send_strategy")]
        public string SendStrategy { get; set; }

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
