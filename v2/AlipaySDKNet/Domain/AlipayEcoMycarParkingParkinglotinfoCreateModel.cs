using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingParkinglotinfoCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingParkinglotinfoCreateModel : AopObject
    {
        /// <summary>
        /// 服务商的支付宝账号ID（2088开头的16位纯数字，<a href="https://opendocs.alipay.com/common/02ncut">获取方式</a>），由服务商提供给ISV
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
        /// 停车场充电车位数 单位:个
        /// </summary>
        [XmlElement("charge_sum_space")]
        public string ChargeSumSpace { get; set; }

        /// <summary>
        /// 停车场详细计费规则
        /// </summary>
        [XmlArray("charging_rule")]
        [XmlArrayItem("parking_lot_charging_rule_info")]
        public List<ParkingLotChargingRuleInfo> ChargingRule { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [XmlElement("city_id")]
        public string CityId { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [XmlElement("contact_alipay")]
        public string ContactAlipay { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [XmlElement("contact_emali")]
        public string ContactEmali { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [XmlElement("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [XmlElement("contact_tel")]
        public string ContactTel { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [XmlElement("contact_weixin")]
        public string ContactWeixin { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [XmlElement("equipment_name")]
        public string EquipmentName { get; set; }

        /// <summary>
        /// 是否支持电子发票。枚举支持： 0：表示不支持。 1：表示支持。
        /// </summary>
        [XmlElement("is_support_invoice")]
        public string IsSupportInvoice { get; set; }

        /// <summary>
        /// ISV电话，传入original_isv_pid、original_isv_appid时，此处为服务商电话
        /// </summary>
        [XmlElement("isv_mobile")]
        public string IsvMobile { get; set; }

        /// <summary>
        /// 纬度 单位:度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度 单位:度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 收款方的支付宝账号ID（2088开头的16位纯数字，<a href="https://opendocs.alipay.com/common/02ncut">获取方式</a>），由停车场收款的业主方提供给ISV，该字段暂用于机具和物料申领
        /// </summary>
        [XmlElement("mchnt_id")]
        public string MchntId { get; set; }

        /// <summary>
        /// ISV的APPID,服务商调用必传，由ISV提供给服务商
        /// </summary>
        [XmlElement("original_isv_appid")]
        public string OriginalIsvAppid { get; set; }

        /// <summary>
        /// ISV电话，此值与isv_mobile组合使用
        /// </summary>
        [XmlElement("original_isv_mobile")]
        public string OriginalIsvMobile { get; set; }

        /// <summary>
        /// ISV的名称，服务商调用必传，由ISV提供给服务商
        /// </summary>
        [XmlElement("original_isv_name")]
        public string OriginalIsvName { get; set; }

        /// <summary>
        /// ISV的PID，服务商调用必传,由ISV提供给服务商
        /// </summary>
        [XmlElement("original_isv_pid")]
        public string OriginalIsvPid { get; set; }

        /// <summary>
        /// ISV停车场ID，由ISV 自定义，同一个isv或商户范围内唯一
        /// </summary>
        [XmlElement("out_parking_id")]
        public string OutParkingId { get; set; }

        /// <summary>
        /// 停车场地址
        /// </summary>
        [XmlElement("parking_address")]
        public string ParkingAddress { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [XmlElement("parking_end_time")]
        public string ParkingEndTime { get; set; }

        /// <summary>
        /// 收费说明
        /// </summary>
        [XmlElement("parking_fee_description")]
        public string ParkingFeeDescription { get; set; }

        /// <summary>
        /// 商户在停车平台露出的停车价格图片；注意：该图片为PNG格式内容为BASE64的字符串，大小不要超过1MB
        /// </summary>
        [XmlElement("parking_fee_description_img")]
        public string ParkingFeeDescriptionImg { get; set; }

        /// <summary>
        /// 停车场类型，COMMUNITY为居民小区、BUSINESS_AREA为商圈停车场（购物中心商业广场商场等）、ROADSIDE为路侧停车、PARK_SCENIC为公园景点（景点乐园公园老街古镇等）、OFFICE_BUILDING为商务楼宇（酒店写字楼商务楼园区等）、OTHER为其他、TRANSPORTATION为交通枢纽（机场火车站汽车站码头港口等）、PUBLIC_FACILITIES为市政设施（体育场博物图书馆医院学校等）、TERRITORY独立园区（办公工业物流园区等）、BUSINESS_PLACE经营场所（4S店、门市餐饮等
        /// </summary>
        [XmlElement("parking_lot_type")]
        public string ParkingLotType { get; set; }

        /// <summary>
        /// 停车场客服电话
        /// </summary>
        [XmlElement("parking_mobile")]
        public string ParkingMobile { get; set; }

        /// <summary>
        /// 停车场名称，由ISV定义，尽量与高德地图上的一致。
        /// </summary>
        [XmlElement("parking_name")]
        public string ParkingName { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [XmlElement("parking_number")]
        public string ParkingNumber { get; set; }

        /// <summary>
        /// 如何获取parking_poiid（高德地图唯一标标识）参考文档 <a href="https://opendocs.alipay.com/support/01rghx">https://opendocs.alipay.com/support/01rghx</a> ；若无法成功获取高德POI时，也可选用经纬度的方式注册。
        /// </summary>
        [XmlElement("parking_poiid")]
        public string ParkingPoiid { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [XmlElement("parking_start_time")]
        public string ParkingStartTime { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [XmlElement("parking_type")]
        public string ParkingType { get; set; }

        /// <summary>
        /// 支付方式。枚举支持： 1：表示支付宝在线缴费。 2：表示支付宝代扣缴费。 3：表示当面付。 4:  现金 说明：如支持多种方式以 ',' 进行分隔。
        /// </summary>
        [XmlElement("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [XmlElement("payment_mode")]
        public string PaymentMode { get; set; }

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
        /// 停车场车位数 单位:个
        /// </summary>
        [XmlElement("sum_space")]
        public string SumSpace { get; set; }

        /// <summary>
        /// 是否支持先离后付。枚举支持： Y：支持。 N：不支持。 说明：默认为空不支持，此参数适用于签约信用代扣的商户。
        /// </summary>
        [XmlElement("support_after_pay")]
        public string SupportAfterPay { get; set; }

        /// <summary>
        /// 用户支付未离场的超时时间(以分钟为单位)
        /// </summary>
        [XmlElement("time_out")]
        public string TimeOut { get; set; }
    }
}
