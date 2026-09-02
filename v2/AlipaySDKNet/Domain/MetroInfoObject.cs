using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MetroInfoObject Data Structure.
    /// </summary>
    [Serializable]
    public class MetroInfoObject : AopObject
    {
        /// <summary>
        /// 调整运营组织列表
        /// </summary>
        [XmlArray("adjust_operation_organization_list")]
        [XmlArrayItem("adjust_operation_organization_object")]
        public List<AdjustOperationOrganizationObject> AdjustOperationOrganizationList { get; set; }

        /// <summary>
        /// 调整线路方向列表
        /// </summary>
        [XmlArray("adjust_route_direction_list")]
        [XmlArrayItem("adjust_route_direction_object")]
        public List<AdjustRouteDirectionObject> AdjustRouteDirectionList { get; set; }

        /// <summary>
        /// 调整建议汇总
        /// </summary>
        [XmlElement("adjustment_suggestions_summary")]
        public string AdjustmentSuggestionsSummary { get; set; }

        /// <summary>
        /// 公交换乘列表
        /// </summary>
        [XmlArray("bus_transfer_list")]
        [XmlArrayItem("bus_transfer_object")]
        public List<BusTransferObject> BusTransferList { get; set; }

        /// <summary>
        /// 公交换乘信息汇总
        /// </summary>
        [XmlElement("bus_transfer_platform_summary")]
        public string BusTransferPlatformSummary { get; set; }

        /// <summary>
        /// 下行方向
        /// </summary>
        [XmlElement("down_direction")]
        public string DownDirection { get; set; }

        /// <summary>
        /// 下行运营时间，单位：min
        /// </summary>
        [XmlElement("down_time")]
        public string DownTime { get; set; }

        /// <summary>
        /// 受影响线路列表
        /// </summary>
        [XmlArray("effect_bus_route_list")]
        [XmlArrayItem("effect_bus_route_object")]
        public List<EffectBusRouteObject> EffectBusRouteList { get; set; }

        /// <summary>
        /// 受影响线路汇总
        /// </summary>
        [XmlElement("effect_bus_route_summary")]
        public string EffectBusRouteSummary { get; set; }

        /// <summary>
        /// 受影响线路站点列表
        /// </summary>
        [XmlArray("effect_bus_station_list")]
        [XmlArrayItem("effect_bus_station_object")]
        public List<EffectBusStationObject> EffectBusStationList { get; set; }

        /// <summary>
        /// 站点出入口信息
        /// </summary>
        [XmlArray("entrance_exit_list")]
        [XmlArrayItem("entrance_exit_object")]
        public List<EntranceExitObject> EntranceExitList { get; set; }

        /// <summary>
        /// 地铁唯一编码
        /// </summary>
        [XmlElement("metro_code")]
        public string MetroCode { get; set; }

        /// <summary>
        /// 地铁长度，单位km
        /// </summary>
        [XmlElement("metro_length")]
        public string MetroLength { get; set; }

        /// <summary>
        /// 地铁名称
        /// </summary>
        [XmlElement("metro_name")]
        public string MetroName { get; set; }

        /// <summary>
        /// 地铁换乘站数量
        /// </summary>
        [XmlElement("metro_station_count")]
        public long MetroStationCount { get; set; }

        /// <summary>
        /// 地铁状态，0：停运,1：正常,2：规划中,3：在建
        /// </summary>
        [XmlElement("metro_status")]
        public long MetroStatus { get; set; }

        /// <summary>
        /// 换乘线路数量
        /// </summary>
        [XmlElement("metro_transfer_route_count")]
        public long MetroTransferRouteCount { get; set; }

        /// <summary>
        /// 换乘线路明细（顿号隔开）
        /// </summary>
        [XmlElement("metro_transfer_route_detail")]
        public string MetroTransferRouteDetail { get; set; }

        /// <summary>
        /// 地铁换乘站数量
        /// </summary>
        [XmlElement("metro_transfer_station_count")]
        public long MetroTransferStationCount { get; set; }

        /// <summary>
        /// 换乘站点信息
        /// </summary>
        [XmlElement("metro_transfer_station_detail")]
        public string MetroTransferStationDetail { get; set; }

        /// <summary>
        /// 并行线路列表
        /// </summary>
        [XmlArray("parallel_bus_route_list")]
        [XmlArrayItem("parallel_route_object")]
        public List<ParallelRouteObject> ParallelBusRouteList { get; set; }

        /// <summary>
        /// 并行公交线路汇总
        /// </summary>
        [XmlElement("parallel_bus_route_summary")]
        public string ParallelBusRouteSummary { get; set; }

        /// <summary>
        /// 客流预测列表
        /// </summary>
        [XmlArray("passenger_flow_predict_list")]
        [XmlArrayItem("passenger_flow_predict_object")]
        public List<PassengerFlowPredictObject> PassengerFlowPredictList { get; set; }

        /// <summary>
        /// 客流预测汇总
        /// </summary>
        [XmlElement("passenger_flow_predict_summary")]
        public string PassengerFlowPredictSummary { get; set; }

        /// <summary>
        /// 站点列表
        /// </summary>
        [XmlArray("station_list")]
        [XmlArrayItem("station_object")]
        public List<StationObject> StationList { get; set; }

        /// <summary>
        /// 上行方向
        /// </summary>
        [XmlElement("up_direction")]
        public string UpDirection { get; set; }

        /// <summary>
        /// 上行运营时间，单位：min
        /// </summary>
        [XmlElement("up_time")]
        public string UpTime { get; set; }
    }
}
