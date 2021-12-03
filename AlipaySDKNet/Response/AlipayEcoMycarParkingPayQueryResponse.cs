using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarParkingPayQueryResponse.
    /// </summary>
    public class AlipayEcoMycarParkingPayQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务失败详细错误码
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 业务返回码描述
        /// </summary>
        [XmlElement("biz_msg")]
        public string BizMsg { get; set; }

        /// <summary>
        /// 扣款时间
        /// </summary>
        [XmlElement("gmt_pay")]
        public string GmtPay { get; set; }

        /// <summary>
        /// SUCCESS("SUCCESS","成功"), FAIL("FAIL","失败"), DOING("DOING","交易处理中"), CANCELING("CANCELING","撤销处理中"), CANCELED("CANCELED","已撤销"), REFUNDED("REFUNDED","已退款"),
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 支付宝停车平台订单号
        /// </summary>
        [XmlElement("parking_order_no")]
        public string ParkingOrderNo { get; set; }

        /// <summary>
        /// 车牌颜色，可选蓝-BLUE、绿-GREEN、黄-YELLOW、白-WHITE、黑-BLACK、黄绿色-LIMEGREEN
        /// </summary>
        [XmlElement("plate_color")]
        public string PlateColor { get; set; }

        /// <summary>
        /// 车牌号，入参回传
        /// </summary>
        [XmlElement("plate_no")]
        public string PlateNo { get; set; }

        /// <summary>
        /// 订单金额，单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 交易失败原因描述
        /// </summary>
        [XmlElement("trade_desc")]
        public string TradeDesc { get; set; }

        /// <summary>
        /// 支付宝的唯一交易流水号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
