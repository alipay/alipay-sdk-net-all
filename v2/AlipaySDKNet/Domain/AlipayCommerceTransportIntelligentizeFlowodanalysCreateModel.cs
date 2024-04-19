using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportIntelligentizeFlowodanalysCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportIntelligentizeFlowodanalysCreateModel : AopObject
    {
        /// <summary>
        /// 【特殊可选】围栏所在城市，当taskType为FlowOdAnalysisTaskTypeEnum.CROSS_CITY时必传
        /// </summary>
        [XmlElement("area_city")]
        public string AreaCity { get; set; }

        /// <summary>
        /// 【可选】城市全量OD对应区域码
        /// </summary>
        [XmlElement("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 【特殊可选】当客流OD分析任务类型为--区域围栏od（CITY_AREA_ALL）/区域围栏不方便od（CITY_AREA_INCONVENIENT）/跨城围栏od（CROSS_CITY）时必填
        /// </summary>
        [XmlElement("area_selected")]
        public Area AreaSelected { get; set; }

        /// <summary>
        /// 城市代码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 公交企业ID
        /// </summary>
        [XmlElement("corp_id")]
        public string CorpId { get; set; }

        /// <summary>
        /// 【特殊可选】跨城目标城市，当taskType为FlowOdAnalysisTaskTypeEnum.CROSS_CITY时必传
        /// </summary>
        [XmlElement("cross_city")]
        public string CrossCity { get; set; }

        /// <summary>
        /// 【可选】是否需要人群标签客流数据 默认false
        /// </summary>
        [XmlElement("crowd_label")]
        public bool CrowdLabel { get; set; }

        /// <summary>
        /// 客流OD分析月份,格式为yyyyMM,与dataTime二选一
        /// </summary>
        [XmlElement("data_month")]
        public string DataMonth { get; set; }

        /// <summary>
        /// 支持多个日期选择，与dataMonth二选一，优先级高于dataMonth
        /// </summary>
        [XmlElement("data_time")]
        public string DataTime { get; set; }

        /// <summary>
        /// 扩展字段，json格式
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 客流OD分析任务类型
        /// </summary>
        [XmlElement("flow_od_analysis_task_type")]
        public string FlowOdAnalysisTaskType { get; set; }

        /// <summary>
        /// 【特殊可选】当客流od任务为STATION_POTENTIAL地铁潜客OD时必填 请按照支付宝标准传参,以数字底座线网版本为准
        /// </summary>
        [XmlElement("line_name")]
        public string LineName { get; set; }

        /// <summary>
        /// 【特殊可选】客流OD分析类型，当taskType为FlowOdAnalysisTaskTypeEnum.CITY_AREA时必传
        /// </summary>
        [XmlElement("pattern")]
        public string Pattern { get; set; }

        /// <summary>
        /// 客流分析精度
        /// </summary>
        [XmlElement("precision")]
        public string Precision { get; set; }

        /// <summary>
        /// 请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 【必填】服务任务名称
        /// </summary>
        [XmlElement("service_task_name")]
        public string ServiceTaskName { get; set; }

        /// <summary>
        /// 【特殊可选】当客流od任务为STATION_POTENTIAL地铁潜客OD时必填 请按照支付宝标准传参,以数字底座线网版本为准
        /// </summary>
        [XmlElement("station_name")]
        public string StationName { get; set; }

        /// <summary>
        /// 【可选】是否需要分时客流数据 默认false
        /// </summary>
        [XmlElement("time_division")]
        public bool TimeDivision { get; set; }

        /// <summary>
        /// 【特殊可选】当客流od任务为STATION_POTENTIAL地铁潜客OD时必填 请按照支付宝标准传参,以数字底座线网版本为准
        /// </summary>
        [XmlElement("traffic_type")]
        public string TrafficType { get; set; }

        /// <summary>
        /// 【可选】是否需要出行方式明细客流数据 默认fasle
        /// </summary>
        [XmlElement("trans_type")]
        public bool TransType { get; set; }
    }
}
