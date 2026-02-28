using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LifeServiceServiceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LifeServiceServiceInfo : AopObject
    {
        /// <summary>
        /// 预约时是否需要指定手艺人
        /// </summary>
        [XmlElement("book_with_technician")]
        public string BookWithTechnician { get; set; }

        /// <summary>
        /// 履约类型
        /// </summary>
        [XmlElement("fulfillment_type")]
        public string FulfillmentType { get; set; }

        /// <summary>
        /// 三方服务项目id
        /// </summary>
        [XmlElement("out_service_id")]
        public string OutServiceId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("service_attrs")]
        [XmlArrayItem("life_service_attr")]
        public List<LifeServiceAttr> ServiceAttrs { get; set; }

        /// <summary>
        /// 服务项目id
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 服务项目名称
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 蚂蚁门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 可预约状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("week_plans")]
        [XmlArrayItem("schedule_week_plan_info")]
        public List<ScheduleWeekPlanInfo> WeekPlans { get; set; }
    }
}
