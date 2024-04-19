using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEngineeringInfrastructureAllBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEngineeringInfrastructureAllBatchqueryModel : AopObject
    {
        /// <summary>
        /// 应用的英文名
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 查询时间区间 起始时间  格式为： yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("begin")]
        public string Begin { get; set; }

        /// <summary>
        /// 查询时间区间 结束时间  格式为 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("end")]
        public string End { get; set; }

        /// <summary>
        /// 唯一code值
        /// </summary>
        [XmlElement("key_code")]
        public string KeyCode { get; set; }

        /// <summary>
        /// 查询条数 不超过1w条每次
        /// </summary>
        [XmlElement("limit")]
        public long Limit { get; set; }
    }
}
