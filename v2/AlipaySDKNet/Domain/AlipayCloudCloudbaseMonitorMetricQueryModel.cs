using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseMonitorMetricQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseMonitorMetricQueryModel : AopObject
    {
        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }

        /// <summary>
        /// 采集频率（示例值为1分钟），单位分钟
        /// </summary>
        [XmlElement("down_sample")]
        public string DownSample { get; set; }

        /// <summary>
        /// 查询的结束时间
        /// </summary>
        [XmlElement("end")]
        public string End { get; set; }

        /// <summary>
        /// 数据为空填充策略（数据为空填充策略，默认补0），zero为固定值
        /// </summary>
        [XmlElement("fill_policy")]
        public string FillPolicy { get; set; }

        /// <summary>
        /// 过滤类型  - literal_or  - not_literal_or  - wildcard  - regexp  - not_regexp_match  - literal  - not_literal
        /// </summary>
        [XmlElement("filter_type")]
        public string FilterType { get; set; }

        /// <summary>
        /// 指标  - total  - success  - fail  - successPercent  - cost  - get_qps_count_60  - put_qps_count_60  - get_latency_avg_60  - put_latency_avg_60  - keys  - used_memory  - instance_input_bytes  - instance_output_bytes  - cmd_qps_count_60  - cmd_latency_avg_60  - request_package_size_sum_60  - response_package_size_sum_60  - statread  - statwrite  - readreqcount  - writereqcount
        /// </summary>
        [XmlElement("metric")]
        public string Metric { get; set; }

        /// <summary>
        /// 查询过滤条件
        /// </summary>
        [XmlElement("monitor_filter")]
        public MonitorFilter MonitorFilter { get; set; }

        /// <summary>
        /// 产品  - FUNCTION  - MONGODB  - OSS  - REDIS
        /// </summary>
        [XmlElement("product")]
        public string Product { get; set; }

        /// <summary>
        /// 查询的开始时间
        /// </summary>
        [XmlElement("start")]
        public string Start { get; set; }
    }
}
