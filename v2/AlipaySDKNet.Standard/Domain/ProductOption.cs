using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProductOption Data Structure.
    /// </summary>
    [Serializable]
    public class ProductOption : AopObject
    {
        /// <summary>
        /// 产品选项区间最大数量
        /// </summary>
        [XmlElement("max_unit")]
        public long MaxUnit { get; set; }

        /// <summary>
        /// 产品选项区间最小数量
        /// </summary>
        [XmlElement("min_unit")]
        public long MinUnit { get; set; }

        /// <summary>
        /// 产品定量区间选项code
        /// </summary>
        [XmlElement("option_code")]
        public string OptionCode { get; set; }

        /// <summary>
        /// 产品选项副标题，所选定量区间的重量
        /// </summary>
        [XmlElement("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 选项标题，对应产品定量区间
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
