using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserUgshoppingOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserUgshoppingOrderQueryModel : AopObject
    {
        /// <summary>
        /// 渠道号
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 订单创建最大时间
        /// </summary>
        [XmlElement("max_order_create_time")]
        public string MaxOrderCreateTime { get; set; }

        /// <summary>
        /// 订单创建最小时间
        /// </summary>
        [XmlElement("min_order_create_time")]
        public string MinOrderCreateTime { get; set; }

        /// <summary>
        /// 开放平台用户id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
