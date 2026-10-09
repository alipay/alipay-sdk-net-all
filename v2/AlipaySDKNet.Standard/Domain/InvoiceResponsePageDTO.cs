using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceResponsePageDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceResponsePageDTO : AopObject
    {
        /// <summary>
        /// 当前数据页码
        /// </summary>
        [XmlElement("current_page")]
        public string CurrentPage { get; set; }

        /// <summary>
        /// 发票
        /// </summary>
        [XmlArray("datas")]
        [XmlArrayItem("invoice_all_response_d_t_o")]
        public List<InvoiceAllResponseDTO> Datas { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 数据总条数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
