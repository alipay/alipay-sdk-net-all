using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardBookingshopSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardBookingshopSyncModel : AopObject
    {
        /// <summary>
        /// 预约时间间隔【stockFetchType=sync时必填】 单位分钟，只能是30的倍数，最小30（半小时），最大 30 * 12（6小时）
        /// </summary>
        [XmlElement("book_interval")]
        public long BookInterval { get; set; }

        /// <summary>
        /// 预约是否需要商家确认，默认false； true     需要，用户发起后，需商家确认； false    不需要，用户发起即完成预约
        /// </summary>
        [XmlElement("book_need_confirm")]
        public bool BookNeedConfirm { get; set; }

        /// <summary>
        /// 是否购卡后才能预约【首次同步门店信息时必填】 true     只能购卡后预约 false    不用购卡也能预约
        /// </summary>
        [XmlElement("book_with_item")]
        public bool BookWithItem { get; set; }

        /// <summary>
        /// 预约时是否需要指定服务【首次同步门店信息时必填】 true     预约时必须指定服务 false    预约时不指定服务，直接预约门店
        /// </summary>
        [XmlElement("book_with_service")]
        public bool BookWithService { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("can_not_book_items")]
        [XmlArrayItem("string")]
        public List<string> CanNotBookItems { get; set; }

        /// <summary>
        /// 最大可预约的连续区间数量【stockFetchType=sync时必填】 最小1，最大6 举例：门店营业时间9:00-21:00，interval=30，则预约时可选时间是9:00,9:30,10:00...20:00,20:30 如果maxBookingCount=1，则一次预约只能选半小时，例如选9:00 如果maxBookingCount=2，则一次预约可以选择一小时，例如选9:00和9:30
        /// </summary>
        [XmlElement("max_book_count")]
        public long MaxBookCount { get; set; }

        /// <summary>
        /// 接受预约信息的appid【首次同步门店信息时必填】
        /// </summary>
        [XmlElement("msg_app_id")]
        public string MsgAppId { get; set; }

        /// <summary>
        /// 外部门店id【可选，有就传】
        /// </summary>
        [XmlElement("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 门店id【必填】
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 门店状态【首次同步门店信息时必填】 active       可预约状态 inactive     不可预约，后续可恢复成active
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 库存获取方式【首次同步门店信息时必填】 sync     同步：服务商同步门店的排期，并在库存有变化时每次同步给安心付 query    查询：每次在预约时，安心付实时查询服务商的库存
        /// </summary>
        [XmlElement("stock_fetch_type")]
        public string StockFetchType { get; set; }

        /// <summary>
        /// 查询库存时，需要指定服务商的appid【获取库存方式=query时必填】
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
