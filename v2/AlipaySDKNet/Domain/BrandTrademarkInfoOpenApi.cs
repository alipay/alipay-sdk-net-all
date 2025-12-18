using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BrandTrademarkInfoOpenApi Data Structure.
    /// </summary>
    [Serializable]
    public class BrandTrademarkInfoOpenApi : AopObject
    {
        /// <summary>
        /// 商标注册地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 商标国际分类代码
        /// </summary>
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 商标有效结束时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 商标名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商标持有人
        /// </summary>
        [XmlElement("owner")]
        public string Owner { get; set; }

        /// <summary>
        /// 商标注册号，中国商标
        /// </summary>
        [XmlElement("reg_no")]
        public string RegNo { get; set; }

        /// <summary>
        /// 商标有效开始时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 商标状态 VALID：生效 INVALID：失效
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
