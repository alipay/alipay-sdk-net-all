using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityVoucherpackageQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityVoucherpackageQueryModel : AopObject
    {
        /// <summary>
        /// 券包id
        /// </summary>
        [XmlElement("voucher_package_id")]
        public string VoucherPackageId { get; set; }
    }
}
