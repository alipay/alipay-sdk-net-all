using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportIntelligentizeWorkshiftCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportIntelligentizeWorkshiftCreateModel : AopObject
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
        /// 下行场站配备的司机数，若填写则执行分场站轮班
        /// </summary>
        [XmlElement("down_driver_count")]
        public long DownDriverCount { get; set; }

        /// <summary>
        /// 扩展参数，json格式，由双方约定取值
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 该线路配备的总司机数
        /// </summary>
        [XmlElement("line_driver_count")]
        public long LineDriverCount { get; set; }

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
        /// 服务任务名称
        /// </summary>
        [XmlElement("service_task_name")]
        public string ServiceTaskName { get; set; }

        /// <summary>
        /// 上行场站配备的司机数，若填写则执行分场站轮班
        /// </summary>
        [XmlElement("up_driver_count")]
        public long UpDriverCount { get; set; }

        /// <summary>
        /// 轮班参数列表
        /// </summary>
        [XmlArray("work_shift_param_list")]
        [XmlArrayItem("work_shift_param")]
        public List<WorkShiftParam> WorkShiftParamList { get; set; }
    }
}
