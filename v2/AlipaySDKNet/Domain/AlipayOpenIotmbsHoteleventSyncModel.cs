using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotmbsHoteleventSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotmbsHoteleventSyncModel : AopObject
    {
        /// <summary>
        /// 事件类型相关的业务配置，参考接入sop，或者联系对接小二获取。
        /// </summary>
        [XmlElement("event_config")]
        public string EventConfig { get; set; }

        /// <summary>
        /// 业务事件类型
        /// </summary>
        [XmlElement("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// 用户刷脸后核身组件返回的foken
        /// </summary>
        [XmlElement("ftoken")]
        public string Ftoken { get; set; }

        /// <summary>
        /// 推送的消息点击后跳转链接
        /// </summary>
        [XmlElement("page")]
        public string Page { get; set; }

        /// <summary>
        /// push消息点击后跳转的支付宝小程序appid
        /// </summary>
        [XmlElement("target_app_id")]
        public string TargetAppId { get; set; }
    }
}
