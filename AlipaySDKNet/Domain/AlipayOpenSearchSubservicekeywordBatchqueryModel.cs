using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSearchSubservicekeywordBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSearchSubservicekeywordBatchqueryModel : AopObject
    {
        /// <summary>
        /// 分页参数，分页查询时使用
        /// </summary>
        [XmlElement("page_number")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 分页参数，分页查询时使用
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 审核状态，服务关键词的审核状态，枚举值，不传该字段表示查询所有状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("target_appid")]
        public string TargetAppid { get; set; }
    }
}
