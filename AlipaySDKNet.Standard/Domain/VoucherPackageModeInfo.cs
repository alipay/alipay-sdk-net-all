using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherPackageModeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherPackageModeInfo : AopObject
    {
        /// <summary>
        /// 券包id，对应alipay.marketing.activity.voucherpackage.query中voucher_package_id。
        /// </summary>
        [XmlElement("voucher_package_id")]
        public string VoucherPackageId { get; set; }
    }
}
