using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusScheduletaskodAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataAiserviceCloudbusScheduletaskodAddModel : AopObject
    {
        /// <summary>
        /// 接口版本
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 城市码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 配制id
        /// </summary>
        [XmlElement("config_id")]
        public string ConfigId { get; set; }

        /// <summary>
        /// 公交公司id
        /// </summary>
        [XmlElement("corp_id")]
        public string CorpId { get; set; }

        /// <summary>
        /// 线路信息
        /// </summary>
        [XmlArray("line_info")]
        [XmlArrayItem("input_schedule_line")]
        public List<InputScheduleLine> LineInfo { get; set; }

        /// <summary>
        /// 任务描述
        /// </summary>
        [XmlElement("task_name")]
        public string TaskName { get; set; }
    }
}
