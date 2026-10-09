using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppMessageSubscriptionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppMessageSubscriptionQueryModel : AopObject
    {
        /// <summary>
        /// 授权令牌
        /// </summary>
        [XmlElement("auth_token")]
        public string AuthToken { get; set; }

        /// <summary>
        /// 授权类型。枚举如下： * app_auth：表示第三方应用授权。 * user_auth：表示用户授权。
        /// </summary>
        [XmlElement("auth_type")]
        public string AuthType { get; set; }

        /// <summary>
        /// 消息标签，用于消息子类型过滤。使用前请确认消息topic是否支持。若topic传入的消息接口中未定义 tag 则不支持传递。
        /// </summary>
        [XmlElement("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// 消息主题名称，即消息接口英文名。
        /// </summary>
        [XmlElement("topic")]
        public string Topic { get; set; }
    }
}
