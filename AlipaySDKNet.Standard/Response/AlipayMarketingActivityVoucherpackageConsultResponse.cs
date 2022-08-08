using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivityVoucherpackageConsultResponse.
    /// </summary>
    public class AlipayMarketingActivityVoucherpackageConsultResponse : AopResponse
    {
        /// <summary>
        /// 券包购买咨询结果
        /// </summary>
        [XmlArray("voucher_package_consult_result")]
        [XmlArrayItem("voucher_package_consult_result")]
        public List<VoucherPackageConsultResult> VoucherPackageConsultResult { get; set; }
    }
}
