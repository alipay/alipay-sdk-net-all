using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportDaijiaPriceModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportDaijiaPriceModifyModel : AopObject
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 车生活订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 订单应付金额；单位分 只有orderstatus=CANCEL_WAIT_PAY（取消待支付）时才允许把金额改成0，其余状态不允许改为0
        /// </summary>
        [XmlElement("total_amount")]
        public long TotalAmount { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
