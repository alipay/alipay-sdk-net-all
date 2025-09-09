using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalBidataBlockinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalBidataBlockinfoQueryModel : AopObject
    {
        /// <summary>
        /// 驾驶舱上不同区域的类型:可选类型如下： "basic_info","trends","hot_words","channel_users","provide_service"
        /// </summary>
        [XmlElement("block_type")]
        public string BlockType { get; set; }

        /// <summary>
        /// 默认传 azeApp
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 2025-03-04表示2025年3月4日
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 2025-03-04 表示2025年3月4号
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
