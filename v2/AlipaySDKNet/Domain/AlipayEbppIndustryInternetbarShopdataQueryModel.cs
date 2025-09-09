using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryInternetbarShopdataQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryInternetbarShopdataQueryModel : AopObject
    {
        /// <summary>
        /// 日期格式为yyyy-MM-dd，返回结果中包含该日期的数据。结束日期可以等于开始日期，但不能早于开始日期。最大日期跨度180天。
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 本次查询的页码，从1开始。默认为1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 单页条数，默认100条/页，最大1000条/页
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 日期格式为yyyy-MM-dd，返回结果中包含该日期的数据
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
