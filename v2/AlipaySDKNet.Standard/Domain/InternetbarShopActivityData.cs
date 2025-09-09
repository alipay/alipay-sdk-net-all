using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InternetbarShopActivityData Data Structure.
    /// </summary>
    [Serializable]
    public class InternetbarShopActivityData : AopObject
    {
        /// <summary>
        /// 历史活跃线圈总数
        /// </summary>
        [XmlElement("active_device_count")]
        public long ActiveDeviceCount { get; set; }

        /// <summary>
        /// 该门店申请的线圈总数
        /// </summary>
        [XmlElement("apply_device_count")]
        public long ApplyDeviceCount { get; set; }

        /// <summary>
        /// 动销数据对应的业务发生日期
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// biz_date对应的当日活跃线圈数
        /// </summary>
        [XmlElement("daily_active_device_count")]
        public long DailyActiveDeviceCount { get; set; }

        /// <summary>
        /// 线圈1日pv
        /// </summary>
        [XmlElement("device_1_day_pv")]
        public long Device1DayPv { get; set; }

        /// <summary>
        /// 线圈最近30日日均pv
        /// </summary>
        [XmlElement("device_30_day_avg_pv")]
        public long Device30DayAvgPv { get; set; }

        /// <summary>
        /// 线圈30日uv
        /// </summary>
        [XmlElement("device_30_day_uv")]
        public long Device30DayUv { get; set; }

        /// <summary>
        /// 线圈dau
        /// </summary>
        [XmlElement("device_dau")]
        public long DeviceDau { get; set; }

        /// <summary>
        /// 最近30天活跃线圈数
        /// </summary>
        [XmlElement("last_30_day_active_device_count")]
        public long Last30DayActiveDeviceCount { get; set; }

        /// <summary>
        /// 门店编号
        /// </summary>
        [XmlElement("shop_code")]
        public string ShopCode { get; set; }

        /// <summary>
        /// 用于区分品牌旗下不同的门店
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 门店中文名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }
    }
}
