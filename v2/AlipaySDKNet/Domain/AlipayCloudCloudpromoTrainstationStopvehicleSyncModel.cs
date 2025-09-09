using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoTrainstationStopvehicleSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoTrainstationStopvehicleSyncModel : AopObject
    {
        /// <summary>
        /// 停车照片链接，车辆状态是已停入，需要传该参数
        /// </summary>
        [XmlElement("car_image_url")]
        public string CarImageUrl { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("car_number")]
        public string CarNumber { get; set; }

        /// <summary>
        /// 离开停车场时间，车辆状态是已出场，需要传该参数
        /// </summary>
        [XmlElement("departure_time")]
        public string DepartureTime { get; set; }

        /// <summary>
        /// 进入停车场时间，车辆状态是已入场，需要传该参数
        /// </summary>
        [XmlElement("enter_time")]
        public string EnterTime { get; set; }

        /// <summary>
        /// 楼层，车辆状态是已停入，需要传该参数
        /// </summary>
        [XmlElement("floor")]
        public string Floor { get; set; }

        /// <summary>
        /// 纬度，当车辆停入车位时，需要传该参数
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 离开车位时间，车辆状态是已停出，需要传该参数
        /// </summary>
        [XmlElement("leave_parking_time")]
        public string LeaveParkingTime { get; set; }

        /// <summary>
        /// 经度，当车辆停入车位时，需要传该参数
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 杭州东1号网约车
        /// </summary>
        [XmlElement("parking_lot_name")]
        public string ParkingLotName { get; set; }

        /// <summary>
        /// 车位号，车辆状态是已停入，需要传该参数
        /// </summary>
        [XmlElement("parking_number")]
        public string ParkingNumber { get; set; }

        /// <summary>
        /// 场所名称
        /// </summary>
        [XmlElement("place_name")]
        public string PlaceName { get; set; }

        /// <summary>
        /// 位置ID，用于区分不同poi点位的唯一值
        /// </summary>
        [XmlElement("poi_id")]
        public string PoiId { get; set; }

        /// <summary>
        /// 已入场：车辆进入停车场 已停入：车辆停入停车位 已停出：车辆离开停车位 已出场：车辆离开停车场（如有采集该数据则更新）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 停入车位时间，车辆状态是已停入，需要传该参数
        /// </summary>
        [XmlElement("stop_time")]
        public string StopTime { get; set; }
    }
}
