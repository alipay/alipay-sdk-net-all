using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniOrderQueryModel : AopObject
    {
        /// <summary>
        /// 用户open_id，和uid二选一
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 小程序交易组件交易号,和商家自定义交易号二选一
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商家自定义交易号，和小程序交易组件交易号二选一
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 用户user_id，和open_id二选一
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
