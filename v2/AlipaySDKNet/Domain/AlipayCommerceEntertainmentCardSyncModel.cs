using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEntertainmentCardSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEntertainmentCardSyncModel : AopObject
    {
        /// <summary>
        /// 卡生效时间，请传生效时间对应毫秒级时间戳。
        /// </summary>
        [XmlElement("active_date")]
        public string ActiveDate { get; set; }

        /// <summary>
        /// 业务变更时间。毫秒级时间戳，serial_number+biz_date为请求幂等键，biz_date小于等于serial_number对应会员卡在数据库的最新变更时间则请求幂等。
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 卡失效时间，请传失效日期对应毫秒级时间戳
        /// </summary>
        [XmlElement("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 会员卡的等级名称。
        /// </summary>
        [XmlElement("level")]
        public string Level { get; set; }

        /// <summary>
        /// SEND_MESSAGE：正常发送卡待过期和已过期消息 SEND_WILL_EXPIRED_MESSAGE：仅发会员卡待过期消息 SEND_EXPIRED_MESSAGE：仅发会员卡已过期消息 NOT_SEND_MESSAGE：不发任何消息
        /// </summary>
        [XmlElement("message_flag")]
        public string MessageFlag { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 会员卡编号，用户维度下该值唯一。
        /// </summary>
        [XmlElement("serial_number")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// 定向开放业务，请联系支付宝业务BD获取对接业务的卡模板编号。
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
