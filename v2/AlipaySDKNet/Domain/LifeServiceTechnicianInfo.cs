using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LifeServiceTechnicianInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LifeServiceTechnicianInfo : AopObject
    {
        /// <summary>
        /// 手艺人头像url
        /// </summary>
        [XmlElement("avatar_url")]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// 手艺人从业开始月份 格式 yyyy-MM
        /// </summary>
        [XmlElement("career_start_month")]
        public string CareerStartMonth { get; set; }

        /// <summary>
        /// 手艺人昵称
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 三方手艺人id
        /// </summary>
        [XmlElement("out_technician_id")]
        public string OutTechnicianId { get; set; }

        /// <summary>
        /// 手艺人手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("service_ids")]
        [XmlArrayItem("string")]
        public List<string> ServiceIds { get; set; }

        /// <summary>
        /// 蚂蚁门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 手艺人状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("technician_attrs")]
        [XmlArrayItem("life_service_attr")]
        public List<LifeServiceAttr> TechnicianAttrs { get; set; }

        /// <summary>
        /// 手艺人id
        /// </summary>
        [XmlElement("technician_id")]
        public string TechnicianId { get; set; }

        /// <summary>
        /// 手艺人岗位头衔
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("week_plans")]
        [XmlArrayItem("schedule_week_plan_info")]
        public List<ScheduleWeekPlanInfo> WeekPlans { get; set; }
    }
}
