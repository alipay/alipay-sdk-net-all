using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcEmployeeVoucherQueryResponse.
    /// </summary>
    public class AlipayCommerceEcEmployeeVoucherQueryResponse : AopResponse
    {
        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数据量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_page_count")]
        public long TotalPageCount { get; set; }

        /// <summary>
        /// 券列表
        /// </summary>
        [XmlElement("voucher_info_list")]
        public VoucherInfoResponse VoucherInfoList { get; set; }
    }
}
