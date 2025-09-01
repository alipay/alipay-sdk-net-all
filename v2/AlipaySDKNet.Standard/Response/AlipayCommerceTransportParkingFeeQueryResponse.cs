using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportParkingFeeQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportParkingFeeQueryResponse : AopResponse
    {
        /// <summary>
        /// 停车场收费规则图片
        /// </summary>
        [XmlElement("charging_rule_img_url")]
        public string ChargingRuleImgUrl { get; set; }

        /// <summary>
        /// 停车场收费规则
        /// </summary>
        [XmlElement("charging_rule_text")]
        public string ChargingRuleText { get; set; }

        /// <summary>
        /// 停车费优惠信息
        /// </summary>
        [XmlElement("discount_info")]
        public string DiscountInfo { get; set; }

        /// <summary>
        /// 高德地图POI
        /// </summary>
        [XmlElement("gaode_map_poi")]
        public string GaodeMapPoi { get; set; }

        /// <summary>
        /// 停车场经纬度
        /// </summary>
        [XmlElement("gaode_map_poi_latitude")]
        public string GaodeMapPoiLatitude { get; set; }

        /// <summary>
        /// 停车场经纬度
        /// </summary>
        [XmlElement("gaode_map_poi_longitude")]
        public string GaodeMapPoiLongitude { get; set; }

        /// <summary>
        /// 入场时间，标准时间格式
        /// </summary>
        [XmlElement("in_place_time")]
        public string InPlaceTime { get; set; }

        /// <summary>
        /// 停车时长，单位会自动转换成x小时x分钟
        /// </summary>
        [XmlElement("park_duration_time")]
        public string ParkDurationTime { get; set; }

        /// <summary>
        /// 停车场地址
        /// </summary>
        [XmlElement("parking_lot_address")]
        public string ParkingLotAddress { get; set; }

        /// <summary>
        /// 停车场名称
        /// </summary>
        [XmlElement("parking_lot_name")]
        public string ParkingLotName { get; set; }

        /// <summary>
        /// 缴费链接
        /// </summary>
        [XmlElement("pay_url")]
        public string PayUrl { get; set; }

        /// <summary>
        /// 停车费金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
