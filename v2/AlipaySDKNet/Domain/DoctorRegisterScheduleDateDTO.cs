using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DoctorRegisterScheduleDateDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DoctorRegisterScheduleDateDTO : AopObject
    {
        /// <summary>
        /// 日期
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 号源统计列表
        /// </summary>
        [XmlArray("number_count_list")]
        [XmlArrayItem("register_number_count_d_t_o")]
        public List<RegisterNumberCountDTO> NumberCountList { get; set; }

        /// <summary>
        /// 枚举值： 有号:1 已约满:2 停诊:3 等待放号:4
        /// </summary>
        [XmlElement("number_status")]
        public string NumberStatus { get; set; }

        /// <summary>
        /// 日期，格式：MM.dd
        /// </summary>
        [XmlElement("register_date")]
        public string RegisterDate { get; set; }

        /// <summary>
        /// 排班id
        /// </summary>
        [XmlElement("register_id")]
        public string RegisterId { get; set; }

        /// <summary>
        /// 星期序号
        /// </summary>
        [XmlElement("week_num")]
        public string WeekNum { get; set; }
    }
}
