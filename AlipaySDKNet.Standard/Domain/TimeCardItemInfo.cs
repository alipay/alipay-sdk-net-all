using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TimeCardItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TimeCardItemInfo : AopObject
    {
        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("extend_info")]
        public TimeCardItemExtendInfo ExtendInfo { get; set; }

        /// <summary>
        /// 次卡商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 卡的logo
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 原价，精确到分
        /// </summary>
        [XmlElement("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 外部业务单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 现价，精确到分
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 状态：已上架ONLINE/已下架OFFLINE
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 次数
        /// </summary>
        [XmlElement("times")]
        public string Times { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
