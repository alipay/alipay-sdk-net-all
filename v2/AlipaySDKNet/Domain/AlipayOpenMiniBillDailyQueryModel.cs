using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniBillDailyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniBillDailyQueryModel : AopObject
    {
        /// <summary>
        /// 分页页码，从1开始
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 要查询的核销日期，格式：yyyyMMdd
        /// </summary>
        [XmlElement("use_date")]
        public string UseDate { get; set; }
    }
}
