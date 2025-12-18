using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AxfBookingServiceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AxfBookingServiceInfo : AopObject
    {
        /// <summary>
        /// 是否购卡后才能预约 true     只能购卡后预约 false    不用购卡也能预约
        /// </summary>
        [XmlElement("book_with_item")]
        public bool BookWithItem { get; set; }

        /// <summary>
        /// 预约时是否需要指定手艺人 true     预约时必须指定手艺人 false    预约时不指定手艺人，直接预约服务
        /// </summary>
        [XmlElement("book_with_technician")]
        public bool BookWithTechnician { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("string")]
        public List<string> Items { get; set; }

        /// <summary>
        /// 外部服务id
        /// </summary>
        [XmlElement("out_service_id")]
        public string OutServiceId { get; set; }

        /// <summary>
        /// 服务id
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 服务状态（枚举） deleted      永久删除，后续不可恢复，不可再被查询到 active       可预约状态 inactive     不可预约，后续可恢复成active
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
