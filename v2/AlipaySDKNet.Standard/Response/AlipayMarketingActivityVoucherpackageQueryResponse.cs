using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivityVoucherpackageQueryResponse.
    /// </summary>
    public class AlipayMarketingActivityVoucherpackageQueryResponse : AopResponse
    {
        /// <summary>
        /// 券包活动信息
        /// </summary>
        [XmlArray("voucher_package_activity_info")]
        [XmlArrayItem("voucher_package_activity_info")]
        public List<VoucherPackageActivityInfo> VoucherPackageActivityInfo { get; set; }

        /// <summary>
        /// 券包基本信息
        /// </summary>
        [XmlElement("voucher_package_base_info")]
        public VoucherPackageBaseInfo VoucherPackageBaseInfo { get; set; }

        /// <summary>
        /// 券包售卖信息
        /// </summary>
        [XmlElement("voucher_package_sales_info")]
        public VoucherPackageSalesInfo VoucherPackageSalesInfo { get; set; }

        /// <summary>
        /// 券包使用规则
        /// </summary>
        [XmlElement("voucher_package_use_rule")]
        public VoucherPackageUseRule VoucherPackageUseRule { get; set; }
    }
}
