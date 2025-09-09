using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RegisterScheduleDateDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RegisterScheduleDateDTO : AopObject
    {
        /// <summary>
        /// 展示日期，格式：MM/dd 为null 表示展示全部号源
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 排班医生列表
        /// </summary>
        [XmlArray("doctor_info_list")]
        [XmlArrayItem("register_doctor_info_d_t_o")]
        public List<RegisterDoctorInfoDTO> DoctorInfoList { get; set; }

        /// <summary>
        /// 号源状态，枚举值 0：无号 1：有号 2：已约满
        /// </summary>
        [XmlElement("number_status")]
        public string NumberStatus { get; set; }

        /// <summary>
        /// 平台挂号日期
        /// </summary>
        [XmlElement("register_date")]
        public string RegisterDate { get; set; }

        /// <summary>
        /// 排班描述
        /// </summary>
        [XmlElement("schedule_desc")]
        public string ScheduleDesc { get; set; }

        /// <summary>
        /// 星期序号，枚举值 周一；周二；周三；周四 周五；周六；周日
        /// </summary>
        [XmlElement("week_num")]
        public string WeekNum { get; set; }
    }
}
