using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalBookOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalBookOrderSyncModel : AopObject
    {
        /// <summary>
        /// 订单详情
        /// </summary>
        [XmlElement("book_order_detail")]
        public BookOrderDetailVO BookOrderDetail { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
