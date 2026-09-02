using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AdjustOperationOrganizationObject Data Structure.
    /// </summary>
    [Serializable]
    public class AdjustOperationOrganizationObject : AopObject
    {
        /// <summary>
        /// 调整运营汇总
        /// </summary>
        [XmlElement("adjust_operational_summary")]
        public string AdjustOperationalSummary { get; set; }

        /// <summary>
        /// 下行调整运营详情
        /// </summary>
        [XmlElement("down_adjust_operational_detail")]
        public string DownAdjustOperationalDetail { get; set; }

        /// <summary>
        /// 下行方向
        /// </summary>
        [XmlElement("down_direction")]
        public string DownDirection { get; set; }

        /// <summary>
        /// 线路名称
        /// </summary>
        [XmlElement("route_name")]
        public string RouteName { get; set; }

        /// <summary>
        /// 上行调整运营详情
        /// </summary>
        [XmlElement("up_adjust_operational_detail")]
        public string UpAdjustOperationalDetail { get; set; }

        /// <summary>
        /// 上行方向
        /// </summary>
        [XmlElement("up_direction")]
        public string UpDirection { get; set; }
    }
}
