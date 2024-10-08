using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationNdeviceMetricsfordayBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceOperationNdeviceMetricsfordayBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 数据总数
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 设备明细列表
        /// </summary>
        [XmlElement("list")]
        public NDeviceMetricsListForDayResponse List { get; set; }

        /// <summary>
        /// 数据页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
