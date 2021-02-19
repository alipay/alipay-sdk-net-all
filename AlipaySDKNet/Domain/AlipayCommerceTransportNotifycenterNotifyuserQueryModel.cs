using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportNotifycenterNotifyuserQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportNotifycenterNotifyuserQueryModel : AopObject
    {
        /// <summary>
        /// 订阅服务唯一标识
        /// </summary>
        [XmlElement("notify_id")]
        public string NotifyId { get; set; }

        /// <summary>
        /// 订阅实体的值，ETC订阅实体为人，则为user_id
        /// </summary>
        [XmlElement("notify_object")]
        public string NotifyObject { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
