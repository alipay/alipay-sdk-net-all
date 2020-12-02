using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportIntelligentizeTimetableCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportIntelligentizeTimetableCreateModel : AopObject
    {
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
        /// 扩展参数，json格式，由双方约定取值
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 线路信息列表，单次请求只支持同一条线路，支持同时计算该线路的上行+下行
        /// </summary>
        [XmlArray("line_info_list")]
        [XmlArrayItem("time_table_line_info")]
        public List<TimeTableLineInfo> LineInfoList { get; set; }

        /// <summary>
        /// 请求ID，唯一标识一次请求，由调用方自行确保唯一性
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 服务任务名称
        /// </summary>
        [XmlElement("service_task_name")]
        public string ServiceTaskName { get; set; }
    }
}
