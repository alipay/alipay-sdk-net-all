using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationGamemarketingBenefitVerifyResponse.
    /// </summary>
    public class AlipayCommerceOperationGamemarketingBenefitVerifyResponse : AopResponse
    {
        /// <summary>
        /// 卡券核销状态
        /// </summary>
        [XmlElement("voucher_verify_status")]
        public bool VoucherVerifyStatus { get; set; }
    }
}
