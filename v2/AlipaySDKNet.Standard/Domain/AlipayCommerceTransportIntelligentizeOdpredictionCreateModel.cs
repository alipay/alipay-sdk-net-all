using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportIntelligentizeOdpredictionCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportIntelligentizeOdpredictionCreateModel : AopObject
    {
        /// <summary>
        /// 城市码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 公交企业自定义ID，需与技术人员确认是否已生效
        /// </summary>
        [XmlElement("corp_id")]
        public string CorpId { get; set; }

        /// <summary>
        /// 客流预测任务扩展参数
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 客流预测对应线路列表
        /// </summary>
        [XmlArray("line_list")]
        [XmlArrayItem("od_prediction_line_info")]
        public List<OdPredictionLineInfo> LineList { get; set; }

        /// <summary>
        /// 指定客流预测数据月份
        /// </summary>
        [XmlElement("month")]
        public string Month { get; set; }

        /// <summary>
        /// 公交地铁公司线网版本
        /// </summary>
        [XmlElement("network_version")]
        public string NetworkVersion { get; set; }

        /// <summary>
        /// COMMON_BUS_OPEN-常规公交开线, COMMON_BUS_DIAGNOSE-常规公交诊断, CUSTOMIZED_BUS_OPEN-定制公交开线
        /// </summary>
        [XmlElement("od_predict_type")]
        public string OdPredictType { get; set; }

        /// <summary>
        /// false-无需计算替代线路;true-需要计算替代线路
        /// </summary>
        [XmlElement("replace")]
        public bool Replace { get; set; }

        /// <summary>
        /// 请求id，每次请求唯一
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 服务任务描述
        /// </summary>
        [XmlElement("service_task_name")]
        public string ServiceTaskName { get; set; }
    }
}
