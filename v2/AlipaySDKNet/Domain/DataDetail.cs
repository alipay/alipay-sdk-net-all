using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DataDetail Data Structure.
    /// </summary>
    [Serializable]
    public class DataDetail : AopObject
    {
        /// <summary>
        /// 数据汇总时间，格式：yyyyMMdd
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 点击量
        /// </summary>
        [XmlElement("click")]
        public long Click { get; set; }

        /// <summary>
        /// 投放转化数据
        /// </summary>
        [XmlArray("conversion_data_list")]
        [XmlArrayItem("conversion_data_detail")]
        public List<ConversionDataDetail> ConversionDataList { get; set; }

        /// <summary>
        /// 消费，单元：分
        /// </summary>
        [XmlElement("cost")]
        public long Cost { get; set; }

        /// <summary>
        /// 展现量
        /// </summary>
        [XmlElement("impression")]
        public long Impression { get; set; }

        /// <summary>
        /// 外部平台导入广告库后，广告投放对应的外部资源ID
        /// </summary>
        [XmlElement("outer_id")]
        public string OuterId { get; set; }
    }
}
