using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivityVoucherpackageBatchqueryResponse.
    /// </summary>
    public class AlipayMarketingActivityVoucherpackageBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 分页参数，当前所在的页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页参数，每页记录数，最大不可超过30
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 券包总数量
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }

        /// <summary>
        /// 券包信息
        /// </summary>
        [XmlArray("voucher_package_info")]
        [XmlArrayItem("voucher_package_info")]
        public List<VoucherPackageInfo> VoucherPackageInfo { get; set; }
    }
}
