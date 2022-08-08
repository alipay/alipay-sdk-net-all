using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherPackageInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherPackageInfo : AopObject
    {
        /// <summary>
        /// 券包基本信息
        /// </summary>
        [XmlElement("voucher_package_base_info")]
        public VoucherPackageBaseInfo VoucherPackageBaseInfo { get; set; }

        /// <summary>
        /// 券包售卖信息轻量版
        /// </summary>
        [XmlElement("voucher_package_sales_lite_info")]
        public VoucherPackageSalesLiteInfo VoucherPackageSalesLiteInfo { get; set; }
    }
}
