using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RouteInfoObject Data Structure.
    /// </summary>
    [Serializable]
    public class RouteInfoObject : AopObject
    {
        /// <summary>
        /// 衔接地铁情况,包含地铁信息
        /// </summary>
        [XmlElement("connected_metro_route_information")]
        public string ConnectedMetroRouteInformation { get; set; }

        /// <summary>
        /// 运营统计信息
        /// </summary>
        [XmlElement("operational_statistics")]
        public string OperationalStatistics { get; set; }

        /// <summary>
        /// 优化建议传递
        /// </summary>
        [XmlElement("optimization_recommendations")]
        public string OptimizationRecommendations { get; set; }

        /// <summary>
        /// 线路基本信息
        /// </summary>
        [XmlElement("route_basic_information")]
        public string RouteBasicInformation { get; set; }

        /// <summary>
        /// 线路综合评价传递
        /// </summary>
        [XmlElement("route_comprehensive_assessment")]
        public string RouteComprehensiveAssessment { get; set; }

        /// <summary>
        /// 线路诊断数据传递
        /// </summary>
        [XmlElement("route_diagnosis")]
        public string RouteDiagnosis { get; set; }

        /// <summary>
        /// 线路名称
        /// </summary>
        [XmlElement("route_name")]
        public string RouteName { get; set; }

        /// <summary>
        /// 线路打分数据，良好[85, 100] ,中等[70, 85),一般[55，70),较差[0，55）
        /// </summary>
        [XmlElement("route_score")]
        public string RouteScore { get; set; }
    }
}
