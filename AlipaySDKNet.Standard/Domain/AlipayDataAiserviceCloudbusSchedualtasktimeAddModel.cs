using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusSchedualtasktimeAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataAiserviceCloudbusSchedualtasktimeAddModel : AopObject
    {
        /// <summary>
        /// 版本号
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 客流预测任务id
        /// </summary>
        [XmlElement("bus_od_pid")]
        public string BusOdPid { get; set; }

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
        /// 时刻表线路信息
        /// </summary>
        [XmlArray("line_info")]
        [XmlArrayItem("input_schedule_time")]
        public List<InputScheduleTime> LineInfo { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [XmlElement("task_name")]
        public string TaskName { get; set; }
    }
}
