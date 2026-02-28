using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLifeserviceServiceSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLifeserviceServiceSyncModel : AopObject
    {
        /// <summary>
        /// 预约时是否需要指定手艺人，默认not_need
        /// </summary>
        [XmlElement("book_with_technician")]
        public string BookWithTechnician { get; set; }

        /// <summary>
        /// 履约类型，默认store_service
        /// </summary>
        [XmlElement("fulfillment_type")]
        public string FulfillmentType { get; set; }

        /// <summary>
        /// 三方服务项目id【需保证唯一性】
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
        /// 服务项目id【首次同步不填，后续更新和out_service_id二选一】
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 服务项目名称，首次同步必填
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 蚂蚁门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 可预约状态，默认active
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
