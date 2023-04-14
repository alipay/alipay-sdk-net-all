using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VehSearchItem Data Structure.
    /// </summary>
    [Serializable]
    public class VehSearchItem : AopObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 业务id 例:biz_scene为PARKING_SERVICE时,biz_id为支付宝唯一车场id
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务场景 暂只支持PARKING_SERVICE(附近停车场)
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 距离，单位为米
        /// </summary>
        [XmlElement("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 高德地图的poiid
        /// </summary>
        [XmlElement("poi_id")]
        public string PoiId { get; set; }

        /// <summary>
        /// 支持服务列表
        /// </summary>
        [XmlArray("support_service_list")]
        [XmlArrayItem("veh_service_item")]
        public List<VehServiceItem> SupportServiceList { get; set; }

        /// <summary>
        /// 剩余停车位。 业务场景为PARKING_SERVICE时才可能有值。
        /// </summary>
        [XmlElement("surplus_parking_space")]
        public string SurplusParkingSpace { get; set; }
    }
}
