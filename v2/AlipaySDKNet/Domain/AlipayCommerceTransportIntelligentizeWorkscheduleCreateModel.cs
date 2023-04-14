using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportIntelligentizeWorkscheduleCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportIntelligentizeWorkscheduleCreateModel : AopObject
    {
        /// <summary>
        /// 城市代码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 公交业主ID
        /// </summary>
        [XmlElement("corp_id")]
        public string CorpId { get; set; }

        /// <summary>
        /// （注意：该字段已废弃）下行首站的临时停车容量，大于等于0整数
        /// </summary>
        [XmlElement("down_first_station_capacity")]
        public long DownFirstStationCapacity { get; set; }

        /// <summary>
        /// 扩展参数，json格式，由双方约定取值
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 线路Key，同一条线路的不同方向该值相同
        /// </summary>
        [XmlElement("line_key")]
        public string LineKey { get; set; }

        /// <summary>
        /// 请求ID，唯一标识一次请求，由调用方自行确保唯一性
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 休息时间列表
        /// </summary>
        [XmlArray("rest_time_list")]
        [XmlArrayItem("rest_time")]
        public List<RestTime> RestTimeList { get; set; }

        /// <summary>
        /// 服务任务名称
        /// </summary>
        [XmlElement("service_task_name")]
        public string ServiceTaskName { get; set; }

        /// <summary>
        /// 使用时刻表中部分方向的数据计算排班，不传表示使用全量的时刻表数据计算排班
        /// </summary>
        [XmlElement("timetable_direction")]
        public string TimetableDirection { get; set; }

        /// <summary>
        /// 版本1.1单个车次结束后的驻站时长（单位：分钟），不传则由算法自行决策驻站时长。 版本1.2该字段从int类型变更为String类型。支持为上行、下行分别设置上限时长、下限时长。同时兼容使用老版本openapi SDK的调用方传入int类型参数。 格式如下（单位：分钟） {     "up_min_break_time":10, // 上行最小驻站时长，也即下行结束之后在主站的最小驻站时长     "up_max_break_time":30, // 上行最大驻站时长，也即下行结束之后在主站的最大驻站时长     "down_min_break_time":10, // 下行最小驻站时长，也即上行结束之后在副站的最小驻站时长     "down_max_break_time":30, // 下行最大驻站时长，也即上行结束之后在副站的最大驻站时长 }
        /// </summary>
        [XmlElement("trip_break_time")]
        public long TripBreakTime { get; set; }

        /// <summary>
        /// （注意：该字段已废弃）上行首站的临时停车容量，大于等于0整数
        /// </summary>
        [XmlElement("up_first_station_capacity")]
        public long UpFirstStationCapacity { get; set; }

        /// <summary>
        /// 班型列表
        /// </summary>
        [XmlArray("work_pattern_list")]
        [XmlArrayItem("work_pattern")]
        public List<WorkPattern> WorkPatternList { get; set; }

        /// <summary>
        /// 不同的排班模式对应不同的排班算法。目前支持： HUMAN_LIKE_BY_WORK_PATTERN：仿人工排班（基于班型） HUMAN_LIKE_BY_MATRIX_TEMPLATE：仿人工排班（基于矩阵模板） DELICATE_BY_WORK_PATTERN_TEMPLATE：精细化排班（基于班型模板） USE_RECOMMENDED_PARAMS_WITH_TIMETABLE_PRIORITY：使用推荐参数排班（时刻表优先） USE_RECOMMENDED_PARAMS_WITH_RESOURCE_PRIORITY：使用推荐参数排班（人车资源优先）
        /// </summary>
        [XmlElement("work_schedule_mode")]
        public string WorkScheduleMode { get; set; }
    }
}
