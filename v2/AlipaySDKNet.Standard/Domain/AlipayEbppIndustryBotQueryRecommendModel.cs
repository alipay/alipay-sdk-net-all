using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryBotQueryRecommendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryBotQueryRecommendModel : AopObject
    {
        /// <summary>
        /// 在获取不到用户定位时，传递的兜底城市编码
        /// </summary>
        [XmlElement("actual_city_code")]
        public string ActualCityCode { get; set; }

        /// <summary>
        /// 机器人id。由业务交付同学在光华平台创建机器人后，提供给机构
        /// </summary>
        [XmlElement("bot_id")]
        public string BotId { get; set; }

        /// <summary>
        /// 机器人对话id。在机器人对话接口出参中会返回该值。
        /// </summary>
        [XmlElement("chat_id")]
        public string ChatId { get; set; }

        /// <summary>
        /// 通过用户定位获取到的城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 访客ID，由调用方提供，比如：自有app用户id、微信用户id等
        /// </summary>
        [XmlElement("identify_id")]
        public string IdentifyId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户提问的问题，同对话接口中传递的query值
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// 机器人问答会话id。在机器人对话接口中会返回该值。
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
