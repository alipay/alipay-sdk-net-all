using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupGroupmsgStatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupGroupmsgStatusModifyModel : AopObject
    {
        /// <summary>
        /// 消息id
        /// </summary>
        [XmlElement("msg_id")]
        public string MsgId { get; set; }

        /// <summary>
        /// 操作类型，对指定消息操作干预。操作说明：1、删除操作delete，当前消息发送状态send_status 是 1初始 2等待发送，才能进行删除操作 2、撤回操作recall，当前消息发送状态send_status 是 4发送完成 6发送部分失败，才能进行撤回操作。
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }
    }
}
