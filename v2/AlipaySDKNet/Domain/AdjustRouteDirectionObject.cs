using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AdjustRouteDirectionObject Data Structure.
    /// </summary>
    [Serializable]
    public class AdjustRouteDirectionObject : AopObject
    {
        /// <summary>
        /// 调整详情
        /// </summary>
        [XmlElement("adjustment_detail")]
        public string AdjustmentDetail { get; set; }

        /// <summary>
        /// 调整方式: cancel(撤销), shorten(截短), split(拆线),skip_stop(跳站),no_adjustment(无调整)
        /// </summary>
        [XmlElement("adjustment_type")]
        public string AdjustmentType { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [XmlElement("rank")]
        public long Rank { get; set; }

        /// <summary>
        /// 线路名称
        /// </summary>
        [XmlElement("route_name")]
        public string RouteName { get; set; }
    }
}
