using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemStockUpdateByIsvItemIdParam Data Structure.
    /// </summary>
    [Serializable]
    public class ItemStockUpdateByIsvItemIdParam : AopObject
    {
        /// <summary>
        /// 库存结束时间, 毫秒精度时间戳
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 外部服务商的疫苗ID定位商品
        /// </summary>
        [XmlElement("isv_item_id")]
        public string IsvItemId { get; set; }

        /// <summary>
        /// 库存开始时间, 毫秒精度时间戳
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 服务商商品时间段库存数量 单位个
        /// </summary>
        [XmlElement("stock")]
        public long Stock { get; set; }
    }
}
