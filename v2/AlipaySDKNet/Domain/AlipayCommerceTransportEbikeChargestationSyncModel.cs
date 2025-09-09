using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEbikeChargestationSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEbikeChargestationSyncModel : AopObject
    {
        /// <summary>
        /// 充电桩设备详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 当sync_type=SAVE且对应的是可用插口数变更
        /// </summary>
        [XmlElement("available_plug_count")]
        public long AvailablePlugCount { get; set; }

        /// <summary>
        /// 用于唯一标识一个品牌
        /// </summary>
        [XmlElement("brand_code")]
        public string BrandCode { get; set; }

        /// <summary>
        /// 充电桩品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 设备所在城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 标识数据来源ISV
        /// </summary>
        [XmlElement("data_source")]
        public string DataSource { get; set; }

        /// <summary>
        /// 跳转支付宝小程序链接
        /// </summary>
        [XmlElement("detail_link_url")]
        public string DetailLinkUrl { get; set; }

        /// <summary>
        /// 设备所在场地类型是否对外开放
        /// </summary>
        [XmlElement("device_field_type")]
        public string DeviceFieldType { get; set; }

        /// <summary>
        /// 充电桩设备所在经纬度（高德坐标系）
        /// </summary>
        [XmlElement("device_lbs")]
        public string DeviceLbs { get; set; }

        /// <summary>
        /// 充电桩设备名称
        /// </summary>
        [XmlElement("device_name")]
        public string DeviceName { get; set; }

        /// <summary>
        /// 充电桩设备编号(唯一标识)
        /// </summary>
        [XmlElement("device_no")]
        public string DeviceNo { get; set; }

        /// <summary>
        /// 设备状态
        /// </summary>
        [XmlElement("device_status")]
        public string DeviceStatus { get; set; }

        /// <summary>
        /// 设备类型枚举 充电桩 1 充电柜 2 换电柜 3
        /// </summary>
        [XmlElement("device_type_code")]
        public string DeviceTypeCode { get; set; }

        /// <summary>
        /// 充电桩收费标准
        /// </summary>
        [XmlElement("fee_desc")]
        public string FeeDesc { get; set; }

        /// <summary>
        /// 场地图片,需要上传可以公网访问的图片链接
        /// </summary>
        [XmlArray("field_image_list")]
        [XmlArrayItem("string")]
        public List<string> FieldImageList { get; set; }

        /// <summary>
        /// 场地服务描述
        /// </summary>
        [XmlArray("field_service_desc")]
        [XmlArrayItem("string")]
        public List<string> FieldServiceDesc { get; set; }

        /// <summary>
        /// 单路最大输出功率 单位: 瓦
        /// </summary>
        [XmlElement("maximum_power")]
        public long MaximumPower { get; set; }

        /// <summary>
        /// 支付方式
        /// </summary>
        [XmlElement("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 充电桩对应的插口总数
        /// </summary>
        [XmlElement("plug_sum")]
        public long PlugSum { get; set; }

        /// <summary>
        /// 充电桩设备所在省
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 站点名称
        /// </summary>
        [XmlElement("station_name")]
        public string StationName { get; set; }

        /// <summary>
        /// 站点编号
        /// </summary>
        [XmlElement("station_no")]
        public string StationNo { get; set; }

        /// <summary>
        /// 请求时机 SAVE:  - 当首次绑定设备，首次新增需要回传所有基础信息 - 后续信息变更，例如设备名称、状态等发生变更 DELETE: 解绑设备或者不维护该设备则需要调用DELETE删除
        /// </summary>
        [XmlElement("sync_type")]
        public string SyncType { get; set; }
    }
}
