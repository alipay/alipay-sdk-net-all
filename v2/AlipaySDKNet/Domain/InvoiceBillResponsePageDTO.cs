using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceBillResponsePageDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceBillResponsePageDTO : AopObject
    {
        /// <summary>
        /// 当前数据页码
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 发票关联的账单
        /// </summary>
        [XmlElement("datas")]
        public InvoiceBillResponseDTO Datas { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总记录
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
