using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportExpresswayCardtripSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportExpresswayCardtripSyncModel : AopObject
    {
        /// <summary>
        /// 具体业务变更时间
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 1、高速收费站出口名称  2、格式为省份/直辖市+收费站名，比如“黑龙江瓦盆窑西站”
        /// </summary>
        [XmlElement("end_station_name")]
        public string EndStationName { get; set; }

        /// <summary>
        /// 1、如果是高速通行场景，该字段为高速出口的时间  2、其他对应路网规范中的chargeTime字段
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 行业开发者身份标识
        /// </summary>
        [XmlElement("isv_id")]
        public string IsvId { get; set; }

        /// <summary>
        /// 行程授权开通外部流水号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 路网侧唯一高速行程单号
        /// </summary>
        [XmlElement("out_trip_id")]
        public string OutTripId { get; set; }

        /// <summary>
        /// 行程金额支付类型
        /// </summary>
        [XmlElement("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 车牌颜色
        /// </summary>
        [XmlElement("plate_color")]
        public string PlateColor { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("plate_no")]
        public string PlateNo { get; set; }

        /// <summary>
        /// 行程服务跳转链接
        /// </summary>
        [XmlElement("service_url")]
        public string ServiceUrl { get; set; }

        /// <summary>
        /// 1、收费站入口名称  2、格式为省份/直辖市+收费站名，比如“黑龙江瓦盆窑西站”
        /// </summary>
        [XmlElement("start_station_name")]
        public string StartStationName { get; set; }

        /// <summary>
        /// 高速收费口进站时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 商户扣费的总金额，单位元
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 行程交易处理状态
        /// </summary>
        [XmlElement("trade_status")]
        public string TradeStatus { get; set; }

        /// <summary>
        /// 支付宝侧高速行程单号，传入则代表更新行程流水相关信息
        /// </summary>
        [XmlElement("trip_id")]
        public string TripId { get; set; }

        /// <summary>
        /// 行程单状态
        /// </summary>
        [XmlElement("trip_status")]
        public string TripStatus { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
