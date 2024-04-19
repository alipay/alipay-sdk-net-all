using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusSchedualtaskAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataAiserviceCloudbusSchedualtaskAddModel : AopObject
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
        /// 下行场站配车数
        /// </summary>
        [XmlElement("down_bus_cnt")]
        public long DownBusCnt { get; set; }

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
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 排班任务
        /// </summary>
        [XmlElement("task_name")]
        public string TaskName { get; set; }

        /// <summary>
        /// 排班
        /// </summary>
        [XmlElement("time_table_pid")]
        public string TimeTablePid { get; set; }

        /// <summary>
        /// 上行场站配车数
        /// </summary>
        [XmlElement("up_bus_cnt")]
        public long UpBusCnt { get; set; }
    }
}
