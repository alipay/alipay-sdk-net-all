using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CollectReceiptOpenApiPageDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CollectReceiptOpenApiPageDTO : AopObject
    {
        /// <summary>
        /// 当前数据页码
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 收款单数据集
        /// </summary>
        [XmlElement("datas")]
        public CollectReceiptOpenApiDTO Datas { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 数据总条数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
