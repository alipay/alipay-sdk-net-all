using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupGroupmsgSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupGroupmsgSendModel : AopObject
    {
        /// <summary>
        /// 是否需要@所有人，不传默认false(不需要@所有人)
        /// </summary>
        [XmlElement("at_all")]
        public bool AtAll { get; set; }

        /// <summary>
        /// 商家自定义的业务id，会记录下来，在查询消息记录列表的时候返回
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
        /// 用于描述周期消息的发送时间
        /// </summary>
        [XmlElement("group_msg_schedule_config")]
        public GroupMsgScheduleConfigVO GroupMsgScheduleConfig { get; set; }

        /// <summary>
        /// 群发消息内容模型
        /// </summary>
        [XmlElement("msg_data")]
        public GroupMessageVO MsgData { get; set; }

        /// <summary>
        /// 群发复合消息内容模型
        /// </summary>
        [XmlArray("msg_data_list")]
        [XmlArrayItem("group_message_v_o")]
        public List<GroupMessageVO> MsgDataList { get; set; }

        /// <summary>
        /// 该参数用于修改时传入创建得到的msgId字段，创建时无需传入，且只有定时发送消息在发送之前可以进行修改，立即发送不支持修改
        /// </summary>
        [XmlElement("msg_id")]
        public string MsgId { get; set; }

        /// <summary>
        /// 该参数用于描述群发消息是立即发送还是定时发送，0表示立即发送，1表示定时发送，2表示周期发送，不填表示定时发送
        /// </summary>
        [XmlElement("send_strategy")]
        public string SendStrategy { get; set; }

        /// <summary>
        /// 该参数使用 yyyy-MM-dd HH:mm:ss 格式的日期，用于设置定时发送的时间，若不填则默认采用当前时间
        /// </summary>
        [XmlElement("send_time")]
        public string SendTime { get; set; }

        /// <summary>
        /// 推送的消息文案标题（参考：好物分享来咯！）
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
