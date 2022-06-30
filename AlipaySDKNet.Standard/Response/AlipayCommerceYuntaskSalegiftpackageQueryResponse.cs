using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceYuntaskSalegiftpackageQueryResponse.
    /// </summary>
    public class AlipayCommerceYuntaskSalegiftpackageQueryResponse : AopResponse
    {
        /// <summary>
        /// 分页页码
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 页面大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }

        /// <summary>
        /// 券包信息
        /// </summary>
        [XmlArray("voucher_package_infos")]
        [XmlArrayItem("yun_task_voucher_package_info")]
        public List<YunTaskVoucherPackageInfo> VoucherPackageInfos { get; set; }
    }
}
