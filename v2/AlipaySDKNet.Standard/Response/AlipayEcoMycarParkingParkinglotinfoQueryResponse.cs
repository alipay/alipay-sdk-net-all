using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarParkingParkinglotinfoQueryResponse.
    /// </summary>
    public class AlipayEcoMycarParkingParkinglotinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 地区编码
        /// </summary>
        [XmlElement("address_id")]
        public string AddressId { get; set; }

        /// <summary>
        /// 服务商ID（2088开头的16位纯数字），由服务商提供给ISV
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 车场业务归属列表
        /// </summary>
        [XmlArray("business_isv")]
        [XmlArrayItem("business_item")]
        public List<BusinessItem> BusinessIsv { get; set; }

        /// <summary>
        /// 停车场详细计费规则
        /// </summary>
        [XmlArray("charging_rule")]
        [XmlArrayItem("parking_lot_charging_rule_info")]
        public List<ParkingLotChargingRuleInfo> ChargingRule { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_id")]
        public string CityId { get; set; }

        /// <summary>
        /// 高德检索地址
        /// </summary>
        [XmlElement("map_poi_address")]
        public string MapPoiAddress { get; set; }

        /// <summary>
        /// 高德检索名称
        /// </summary>
        [XmlElement("map_poi_name")]
        public string MapPoiName { get; set; }

        /// <summary>
        /// 收款方ID（2088开头的16位纯数字），由停车场收款的业主方提供给ISV，该字段暂用于机具和物料申领
        /// </summary>
        [XmlElement("mchnt_id")]
        public string MchntId { get; set; }

        /// <summary>
        /// ISV停车场ID，由ISV提供，同一个isv或商户范围内唯一
        /// </summary>
        [XmlElement("out_parking_id")]
        public string OutParkingId { get; set; }

        /// <summary>
        /// 停车场地址
        /// </summary>
        [XmlElement("parking_address")]
        public string ParkingAddress { get; set; }

        /// <summary>
        /// 收费说明
        /// </summary>
        [XmlElement("parking_fee_description")]
        public string ParkingFeeDescription { get; set; }

        /// <summary>
        /// 商户在停车平台露出的停车价格图片地址
        /// </summary>
        [XmlElement("parking_fee_description_img")]
        public string ParkingFeeDescriptionImg { get; set; }

        /// <summary>
        /// 支付宝返回停车场id，系统唯一
        /// </summary>
        [XmlElement("parking_id")]
        public string ParkingId { get; set; }

        /// <summary>
        /// 停车场位置经度（优先高德坐标获取结果）单位：度
        /// </summary>
        [XmlElement("parking_latitude")]
        public string ParkingLatitude { get; set; }

        /// <summary>
        /// 停车场位置经度（优先高德坐标获取结果）单位：度
        /// </summary>
        [XmlElement("parking_longitude")]
        public string ParkingLongitude { get; set; }

        /// <summary>
        /// 停车场类型，1为居民小区、2为商圈停车场（购物中心商业广场商场等）、3为路侧停车、4为公园景点（景点乐园公园老街古镇等）、5为商务楼宇（酒店写字楼商务楼园区等）、6为其他、7为交通枢纽（机场火车站汽车站码头港口等）、8为市政设施（体育场博物图书馆医院学校等）、9独立园区（办公工业物流园区等）、10经营场所（4S店、门市餐饮等
        /// </summary>
        [XmlElement("parking_lot_type")]
        public string ParkingLotType { get; set; }

        /// <summary>
        /// 停车场类型，COMMUNITY为居民小区、BUSINESS_AREA为商圈停车场（购物中心商业广场商场等）、ROADSIDE为路侧停车、PARK_SCENIC为公园景点（景点乐园公园老街古镇等）、OFFICE_BUILDING为商务楼宇（酒店写字楼商务楼园区等）、OTHER为其他、TRANSPORTATION为交通枢纽（机场火车站汽车站码头港口等）、PUBLIC_FACILITIES为市政设施（体育场博物图书馆医院学校等）、TERRITORY独立园区（办公工业物流园区等）、BUSINESS_PLACE经营场所（4S店、门市餐饮等
        /// </summary>
        [XmlElement("parking_lot_type_code")]
        public string ParkingLotTypeCode { get; set; }

        /// <summary>
        /// 停车场客服电话
        /// </summary>
        [XmlElement("parking_mobile")]
        public string ParkingMobile { get; set; }

        /// <summary>
        /// 停车场名称，由ISV定义，尽量与高德地图上的一致
        /// </summary>
        [XmlElement("parking_name")]
        public string ParkingName { get; set; }

        /// <summary>
        /// 高德地图唯一标识
        /// </summary>
        [XmlElement("parking_poiid")]
        public string ParkingPoiid { get; set; }

        /// <summary>
        /// 支付方式（1为支付宝在线缴费，2为支付宝代扣缴费，3当面付 4现金)，如支持多种方式以','进行间隔
        /// </summary>
        [XmlElement("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 省份编码
        /// </summary>
        [XmlElement("province_id")]
        public string ProvinceId { get; set; }

        /// <summary>
        /// 提供用户查看停车状态、缴费功能
        /// </summary>
        [XmlElement("serivce_url")]
        public string SerivceUrl { get; set; }

        /// <summary>
        /// 停车场服务信息列表
        /// </summary>
        [XmlArray("service_list")]
        [XmlArrayItem("parking_lot_service_info")]
        public List<ParkingLotServiceInfo> ServiceList { get; set; }

        /// <summary>
        /// 商圈id
        /// </summary>
        [XmlElement("shopingmall_id")]
        public string ShopingmallId { get; set; }

        /// <summary>
        /// 用户支付未离场的超时时间(以分钟为单位)
        /// </summary>
        [XmlElement("time_out")]
        public string TimeOut { get; set; }
    }
}
