using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportParkingReserveConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportParkingReserveConfirmModel : AopObject
    {
        /// <summary>
        /// true-预约成功，false-预约失败
        /// </summary>
        [XmlElement("conf_reslut")]
        public string ConfReslut { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 支付宝预约单唯一ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// isv内部生成唯一订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 支付宝返回停车场ID
        /// </summary>
        [XmlElement("parking_id")]
        public string ParkingId { get; set; }
    }
}
