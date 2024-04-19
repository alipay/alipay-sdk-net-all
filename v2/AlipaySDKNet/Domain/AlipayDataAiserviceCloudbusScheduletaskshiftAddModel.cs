using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusScheduletaskshiftAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataAiserviceCloudbusScheduletaskshiftAddModel : AopObject
    {
        /// <summary>
        /// 接口版本号
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 公交公司id
        /// </summary>
        [XmlElement("corp_id")]
        public string CorpId { get; set; }

        /// <summary>
        /// 待轮班的日期天数
        /// </summary>
        [XmlElement("cycle_cnt")]
        public long CycleCnt { get; set; }

        /// <summary>
        /// 该线路配备的司机数
        /// </summary>
        [XmlElement("driver_cnt")]
        public long DriverCnt { get; set; }

        /// <summary>
        /// 拓展参数
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 线路id
        /// </summary>
        [XmlElement("line_id")]
        public string LineId { get; set; }

        /// <summary>
        /// 待排班的时期列表，多个用逗号分隔
        /// </summary>
        [XmlArray("shift_date_list")]
        [XmlArrayItem("string")]
        public List<string> ShiftDateList { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [XmlElement("task_name")]
        public string TaskName { get; set; }

        /// <summary>
        /// 排班任务id
        /// </summary>
        [XmlArray("work_schedule_pids")]
        [XmlArrayItem("string")]
        public List<string> WorkSchedulePids { get; set; }
    }
}
