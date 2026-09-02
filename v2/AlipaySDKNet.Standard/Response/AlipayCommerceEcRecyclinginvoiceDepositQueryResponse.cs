using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceDepositQueryResponse.
    /// </summary>
    public class AlipayCommerceEcRecyclinginvoiceDepositQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页实际数据条数
        /// </summary>
        [XmlElement("curr_page_size")]
        public long CurrPageSize { get; set; }

        /// <summary>
        /// 待入账订单信息
        /// </summary>
        [XmlElement("data_list")]
        public DepositQueryOpenResult DataList { get; set; }

        /// <summary>
        /// 页号
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小，条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数量，条数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
