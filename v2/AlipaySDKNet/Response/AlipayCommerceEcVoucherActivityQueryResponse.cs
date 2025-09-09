using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcVoucherActivityQueryResponse.
    /// </summary>
    public class AlipayCommerceEcVoucherActivityQueryResponse : AopResponse
    {
        /// <summary>
        /// 券活动
        /// </summary>
        [XmlArray("activity_list")]
        [XmlArrayItem("voucher_activity_response")]
        public List<VoucherActivityResponse> ActivityList { get; set; }

        /// <summary>
        /// 分页页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页每页数据量
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
