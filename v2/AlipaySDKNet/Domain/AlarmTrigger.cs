using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlarmTrigger Data Structure.
    /// </summary>
    [Serializable]
    public class AlarmTrigger : AopObject
    {
        /// <summary>
        /// 数据聚合方式  - sum  - avg
        /// </summary>
        [XmlElement("aggregator")]
        public string Aggregator { get; set; }

        /// <summary>
        /// 数据聚合范围(分钟)  - 1  - 5  - 10  - 15  - 30  - 60
        /// </summary>
        [XmlElement("aggregator_range")]
        public string AggregatorRange { get; set; }

        /// <summary>
        /// 报警比较规则
        /// </summary>
        [XmlArray("compare_rules")]
        [XmlArrayItem("alarm_compare_rule")]
        public List<AlarmCompareRule> CompareRules { get; set; }

        /// <summary>
        /// 最近 N 分钟
        /// </summary>
        [XmlElement("condition_type")]
        public string ConditionType { get; set; }

        /// <summary>
        /// 查询条件过滤
        /// </summary>
        [XmlArray("function_filters")]
        [XmlArrayItem("alarm_function_filter")]
        public List<AlarmFunctionFilter> FunctionFilters { get; set; }

        /// <summary>
        /// 指标  - total  - success  - fail  - successPercent  - cost  - get_qps_count_60  - put_qps_count_60  - get_latency_avg_60  - put_latency_avg_60  - keys  - used_memory  - instance_input_bytes  - instance_output_bytes  - cmd_qps_count_60  - cmd_latency_avg_60  - request_package_size_sum_60  - response_package_size_sum_60
        /// </summary>
        [XmlElement("metric")]
        public string Metric { get; set; }

        /// <summary>
        /// 产品  - FUNCTION  - MONGODB  - OSS  - REDIS
        /// </summary>
        [XmlElement("product")]
        public string Product { get; set; }

        /// <summary>
        /// 数据库/OSS操作类型  - mongodbRead  - mongodbWrite  - ossUpload  - ossDownload  - ossDelete
        /// </summary>
        [XmlElement("product_operate")]
        public string ProductOperate { get; set; }

        /// <summary>
        /// 触发类型 N 值
        /// </summary>
        [XmlElement("step_num")]
        public string StepNum { get; set; }

        /// <summary>
        /// 数据为空是否补零(默认 true)
        /// </summary>
        [XmlElement("zero_fill")]
        public bool ZeroFill { get; set; }
    }
}
