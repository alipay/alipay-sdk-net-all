using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLifeserviceShopSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLifeserviceShopSyncModel : AopObject
    {
        /// <summary>
        /// 预约时间间隔【stockFetchType=sync时必填】 单位分钟，只能是15的倍数，最小15（15分钟），最大 15 * 24（6小时）
        /// </summary>
        [XmlElement("book_interval")]
        public long BookInterval { get; set; }

        /// <summary>
        /// 预约是否需要商家确认，首次同步必填
        /// </summary>
        [XmlElement("book_need_confirm")]
        public string BookNeedConfirm { get; set; }

        /// <summary>
        /// 最大可预约的连续区间数量【stockFetchType=sync时必填】 最小1，最大6 举例：门店营业时间9:00-21:00，interval=30，则预约时可选时间是9:00,9:30,10:00...20:00,20:30 如果maxBookingCount=1，则一次预约只能选半小时，例如选9:00 如果maxBookingCount=2，则一次预约可以选择一小时，例如选9:00和9:30
        /// </summary>
        [XmlElement("max_book_count")]
        public long MaxBookCount { get; set; }

        /// <summary>
        /// 接受预约信息的appid，首次同步必填
        /// </summary>
        [XmlElement("msg_app_id")]
        public string MsgAppId { get; set; }

        /// <summary>
        /// 外部门店id，有就传，要保证唯一性
        /// </summary>
        [XmlElement("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("shop_attrs")]
        [XmlArrayItem("life_service_attr")]
        public List<LifeServiceAttr> ShopAttrs { get; set; }

        /// <summary>
        /// 蚂蚁门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 门店类型，首次同步必填
        /// </summary>
        [XmlElement("shop_type")]
        public string ShopType { get; set; }

        /// <summary>
        /// 门店可预约状态，首次同步必填
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 库存获取方式，首次同步必填
        /// </summary>
        [XmlElement("stock_fetch_type")]
        public string StockFetchType { get; set; }

        /// <summary>
        /// 查询库存的appid，库存方式=query时需要
        /// </summary>
        [XmlElement("stock_query_app_id")]
        public string StockQueryAppId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("week_plans")]
        [XmlArrayItem("schedule_week_plan_info")]
        public List<ScheduleWeekPlanInfo> WeekPlans { get; set; }
    }
}
