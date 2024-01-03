using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceTapOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceTapOrderSyncModel : AopObject
    {
        /// <summary>
        /// 使用年限
        /// </summary>
        [XmlElement("battery_life")]
        public string BatteryLife { get; set; }

        /// <summary>
        /// 电池规格
        /// </summary>
        [XmlElement("battery_special")]
        public string BatterySpecial { get; set; }

        /// <summary>
        /// 预约结束时间
        /// </summary>
        [XmlElement("book_end_time")]
        public string BookEndTime { get; set; }

        /// <summary>
        /// 预约开始时间
        /// </summary>
        [XmlElement("book_start_time")]
        public string BookStartTime { get; set; }

        /// <summary>
        /// 市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 成交价格，单位为分
        /// </summary>
        [XmlElement("complete_price")]
        public long CompletePrice { get; set; }

        /// <summary>
        /// 订单成交时间
        /// </summary>
        [XmlElement("complete_time")]
        public string CompleteTime { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 预留字段
        /// </summary>
        [XmlElement("data_info")]
        public string DataInfo { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("detail_address")]
        public string DetailAddress { get; set; }

        /// <summary>
        /// 地区名称
        /// </summary>
        [XmlElement("district_name")]
        public string DistrictName { get; set; }

        /// <summary>
        /// isv订单号
        /// </summary>
        [XmlElement("isv_order_id")]
        public string IsvOrderId { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        [XmlElement("notify_type")]
        public string NotifyType { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 省名称
        /// </summary>
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
