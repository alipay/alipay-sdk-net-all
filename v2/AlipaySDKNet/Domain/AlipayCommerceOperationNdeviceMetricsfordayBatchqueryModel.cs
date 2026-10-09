using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationNdeviceMetricsfordayBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationNdeviceMetricsfordayBatchqueryModel : AopObject
    {
        /// <summary>
        /// 数据统计时间，具体到某年某月某天，2024年09月19日
        /// </summary>
        [XmlElement("metrics_date")]
        public string MetricsDate { get; set; }

        /// <summary>
        /// 第几页，分页参数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 一页多少，分页参数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 设备sn号
        /// </summary>
        [XmlArray("sn_list")]
        [XmlArrayItem("string")]
        public List<string> SnList { get; set; }

        /// <summary>
        /// 外部门店号
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
