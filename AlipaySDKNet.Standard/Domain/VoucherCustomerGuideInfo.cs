using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherCustomerGuideInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherCustomerGuideInfo : AopObject
    {
        /// <summary>
        /// 券发放引导
        /// </summary>
        [XmlElement("voucher_send_guide_info")]
        public VoucherSendGuideInfo VoucherSendGuideInfo { get; set; }

        /// <summary>
        /// 券核销详情
        /// </summary>
        [XmlElement("voucher_use_guide_info")]
        public VoucherUseGuideInfo VoucherUseGuideInfo { get; set; }
    }
}
