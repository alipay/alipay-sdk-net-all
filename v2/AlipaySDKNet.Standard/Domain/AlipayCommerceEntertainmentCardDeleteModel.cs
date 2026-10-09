using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEntertainmentCardDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEntertainmentCardDeleteModel : AopObject
    {
        /// <summary>
        /// 业务变更时间。毫秒级时间戳，serial_number+biz_date为请求幂等键，biz_date小于等于serial_number对应会员卡在数据库的最新变更时间则请求幂等。
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

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
