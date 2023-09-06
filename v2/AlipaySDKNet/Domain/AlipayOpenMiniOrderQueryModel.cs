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
        /// 买家open_id，和uid二选一
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 交易组件订单号,和商家自定义交易号二选一
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商家自定义订单号，和小程序交易组件交易号二选一
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 买家支付宝用户ID；open_id和user_id二选一
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
