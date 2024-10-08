using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupMsgDetailVO Data Structure.
    /// </summary>
    [Serializable]
    public class GroupMsgDetailVO : AopObject
    {
        /// <summary>
        /// 是否@所有人
        /// </summary>
        [XmlElement("at_all")]
        public bool AtAll { get; set; }

        /// <summary>
        /// 商家自定义的业务id
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 群组id列表，创建群组时对应的一个群组id
        /// </summary>
        [XmlArray("group_ids")]
        [XmlArrayItem("string")]
        public List<string> GroupIds { get; set; }

        /// <summary>
        /// 创建者
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 群发消息内容模型
        /// </summary>
        [XmlElement("msg_data")]
        public GroupMessageVO MsgData { get; set; }

        /// <summary>
        /// 消息id
        /// </summary>
        [XmlElement("msg_id")]
        public string MsgId { get; set; }

        /// <summary>
        /// 发送状态， 2:待发送, 3: 发送中, 4: 发送成功, 5: 发送失败, 6: 部分失败, 7: 重发, 8: 待撤回, 9: 撤回中, 10: 已撤回, 12: 部分撤回, 13: 部分成功, 14: 部分删除, 15: 部分发送中
        /// </summary>
        [XmlElement("send_status")]
        public long SendStatus { get; set; }

        /// <summary>
        /// 发送策略。目前支持0（立即发送）。
        /// </summary>
        [XmlElement("send_strategy")]
        public string SendStrategy { get; set; }

        /// <summary>
        /// 发送时间
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
