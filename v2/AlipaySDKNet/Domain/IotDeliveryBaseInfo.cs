using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IotDeliveryBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IotDeliveryBaseInfo : AopObject
    {
        /// <summary>
        /// 投放计划开始时间。 格式为：yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [XmlElement("delivery_begin_time")]
        public string DeliveryBeginTime { get; set; }

        /// <summary>
        /// 投放计划结束时间。 格式为：yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [XmlElement("delivery_end_time")]
        public string DeliveryEndTime { get; set; }

        /// <summary>
        /// 投放计划名称。 投放计划名称不会对用户进行表达，只用于商户管理使用。长度需要大于等于3，小于32。
        /// </summary>
        [XmlElement("delivery_name")]
        public string DeliveryName { get; set; }

        /// <summary>
        /// 设备名单上传接口返回文件id。在创建投放时传参使用，查询投放时不返回
        /// </summary>
        [XmlElement("device_file_id")]
        public string DeviceFileId { get; set; }

        /// <summary>
        /// 文件链接，可通过此链接下载之前上传的机具文件，查询时返回，创建时无须传参
        /// </summary>
        [XmlElement("device_file_url")]
        public string DeviceFileUrl { get; set; }

        /// <summary>
        /// 不投放门店列表
        /// </summary>
        [XmlElement("exclude_shop_ids")]
        public string ExcludeShopIds { get; set; }

        /// <summary>
        /// 投放门店列表
        /// </summary>
        [XmlElement("include_shop_ids")]
        public string IncludeShopIds { get; set; }

        /// <summary>
        /// 金额门槛下限 限制：value > 0 && value <= 99999。
        /// </summary>
        [XmlElement("trade_down_threshold")]
        public string TradeDownThreshold { get; set; }

        /// <summary>
        /// 金额门槛上限 限制：value > 0 && value <= 99999。
        /// </summary>
        [XmlElement("trade_upon_threshold")]
        public string TradeUponThreshold { get; set; }
    }
}
