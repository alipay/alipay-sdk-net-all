using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VehiclePromoResult Data Structure.
    /// </summary>
    [Serializable]
    public class VehiclePromoResult : AopObject
    {
        /// <summary>
        /// 业务发生时间，格式为yyyy-MM-dd hh:mm:ss
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 订单核销车企优惠金额，精度两位小数，单位元；当退款时，金额为负数；当金额为零时，本订单未核销使用车企优惠
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 订单唯一编码
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 退款订单流水号，当发生退款时，返回该字段信息
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }
    }
}
