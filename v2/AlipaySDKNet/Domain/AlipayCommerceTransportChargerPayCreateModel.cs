using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportChargerPayCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportChargerPayCreateModel : AopObject
    {
        /// <summary>
        /// 商户优惠的订单金额。 单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 电量费用。单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("elec_money")]
        public string ElecMoney { get; set; }

        /// <summary>
        /// 充电结束时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户订单号。 订单支付时传入的商户订单号，商家自定义且保证商家系统中唯一
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 用户需要支付订单金额。 单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 用户需要支付的电费。单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("real_elec_money")]
        public string RealElecMoney { get; set; }

        /// <summary>
        /// 用户需要支付的服务费。单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("real_service_money")]
        public string RealServiceMoney { get; set; }

        /// <summary>
        /// 订单包含的占位费。单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("reserved_money")]
        public string ReservedMoney { get; set; }

        /// <summary>
        /// 服务费用。单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("service_money")]
        public string ServiceMoney { get; set; }

        /// <summary>
        /// 电池剩余电量，两位小数；当订单类型为即插即充时，必传
        /// </summary>
        [XmlElement("soc")]
        public string Soc { get; set; }

        /// <summary>
        /// 充电开始时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 充电停止原因
        /// </summary>
        [XmlElement("stop_reason")]
        public string StopReason { get; set; }

        /// <summary>
        /// 订单总金额。 单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 充电量，单位kwh，两位小数
        /// </summary>
        [XmlElement("total_power")]
        public string TotalPower { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
