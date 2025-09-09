using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarbonCopies Data Structure.
    /// </summary>
    [Serializable]
    public class CarbonCopies : AopObject
    {
        /// <summary>
        /// 签署邮件抄送邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 抄送人的姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 人员唯一id，每人邮箱分配一个，不重复即可
        /// </summary>
        [XmlElement("recipient_id")]
        public string RecipientId { get; set; }

        /// <summary>
        /// 发送顺序 1~10 不同的人请保持不一致
        /// </summary>
        [XmlElement("routing_order")]
        public long RoutingOrder { get; set; }
    }
}
