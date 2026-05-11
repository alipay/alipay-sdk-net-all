using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentDispatchItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RentDispatchItemInfo : AopObject
    {
        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("item_cnt")]
        public string ItemCnt { get; set; }

        /// <summary>
        /// 商户侧商品id
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 商户侧商品sku_id
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 租期天数
        /// </summary>
        [XmlElement("rent_days")]
        public long RentDays { get; set; }

        /// <summary>
        /// 租期起始时间。匹配格式yyyy-MM-dd HH:mm:ss的date类型
        /// </summary>
        [XmlElement("rent_start_time")]
        public string RentStartTime { get; set; }
    }
}
