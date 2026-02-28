using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportOnlinerideOrderFreezeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportOnlinerideOrderFreezeModel : AopObject
    {
        /// <summary>
        /// 0:代表不绕圈 1:代表绕圈
        /// </summary>
        [XmlElement("docking_circle")]
        public long DockingCircle { get; set; }

        /// <summary>
        /// 预计接驾时间,单位:分钟 
        /// </summary>
        [XmlElement("estimated_pickup_time")]
        public long EstimatedPickupTime { get; set; }

        /// <summary>
        /// 是否存在司机
        /// </summary>
        [XmlElement("exist_driver")]
        public bool ExistDriver { get; set; }

        /// <summary>
        /// 支付宝订单id
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 接驾路线id
        /// </summary>
        [XmlElement("pick_up_route_id")]
        public string PickUpRouteId { get; set; }

        /// <summary>
        /// 外部商户的订单id
        /// </summary>
        [XmlElement("schedule_id")]
        public string ScheduleId { get; set; }

        /// <summary>
        /// 是否升仓
        /// </summary>
        [XmlElement("upgrade_status")]
        public bool UpgradeStatus { get; set; }

        /// <summary>
        /// 预估接驾距离,单位:米
        /// </summary>
        [XmlElement("vehicle_distance")]
        public long VehicleDistance { get; set; }

        /// <summary>
        /// 车辆信息
        /// </summary>
        [XmlElement("vehicle_info")]
        public VehicleLocationInfo VehicleInfo { get; set; }
    }
}
