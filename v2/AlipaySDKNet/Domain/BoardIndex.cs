using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BoardIndex Data Structure.
    /// </summary>
    [Serializable]
    public class BoardIndex : AopObject
    {
        /// <summary>
        /// 指标描述tips
        /// </summary>
        [XmlElement("index_desc")]
        public string IndexDesc { get; set; }

        /// <summary>
        /// 指标key，全局唯一，查询内容参考：<a href="https://opendocs.alipay.com/pre-open/04phhq#%E8%B6%8B%E5%8A%BF%E5%88%86%E6%9E%90%E4%B8%8D%E5%90%8Cindex_key%E6%9F%A5%E8%AF%A2" target="_blank">趋势分析不同index_key查询</a>
        /// </summary>
        [XmlElement("index_key")]
        public string IndexKey { get; set; }

        /// <summary>
        /// 指标名称
        /// </summary>
        [XmlElement("index_name")]
        public string IndexName { get; set; }

        /// <summary>
        /// 指标值
        /// </summary>
        [XmlElement("index_value")]
        public string IndexValue { get; set; }

        /// <summary>
        /// 数据产出日期，格式yyyyMMdd
        /// </summary>
        [XmlElement("report_date")]
        public string ReportDate { get; set; }
    }
}
