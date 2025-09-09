using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupAssistantMsgstatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupAssistantMsgstatusModifyModel : AopObject
    {
        /// <summary>
        /// 小助手内容id，创建定向消息时返回的数据唯一id
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 小助手定向消息更新状态  1、INVALID(下线)，下线操作只能在发送成功后的上线状态才可以下线操作； 2、VALID(上线)，上线操作只能在下线状态下才可以操作； 3、DELETED(删除状态)，删除操作只能在未开始发送之前 或者 下线状态下才可以操作；  状态流转如下： VALID(发送完成状态) -> INVALID(下线状态)； INVALID(下线状态) -> VALID(上线状态)； INIT(初始化)、AUDITING(审核中)、PENDING(待发送)、INVALID(下线操作) -> DELETED(删除状态)；
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
