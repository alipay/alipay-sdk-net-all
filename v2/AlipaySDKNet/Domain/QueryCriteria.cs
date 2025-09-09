using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QueryCriteria Data Structure.
    /// </summary>
    [Serializable]
    public class QueryCriteria : AopObject
    {
        /// <summary>
        /// 输入结束时间时，开始时间不能为空
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 如果输入开始外呼时间,默认查询开始日期后30天
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
