using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceExpensesceneMerchantQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceExpensesceneMerchantQueryResponse : AopResponse
    {
        /// <summary>
        /// 商户信息
        /// </summary>
        [XmlArray("expense_merchant_info_list")]
        [XmlArrayItem("expense_merchant_info")]
        public List<ExpenseMerchantInfo> ExpenseMerchantInfoList { get; set; }

        /// <summary>
        /// 当前页数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 当前记录数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_page_count")]
        public long TotalPageCount { get; set; }
    }
}
