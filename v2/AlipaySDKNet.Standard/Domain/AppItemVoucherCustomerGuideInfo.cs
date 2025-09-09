using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemVoucherCustomerGuideInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemVoucherCustomerGuideInfo : AopObject
    {
        /// <summary>
        /// 券核销引导
        /// </summary>
        [XmlElement("app_item_voucher_use_guide_info")]
        public AppItemVoucherUseGuideInfo AppItemVoucherUseGuideInfo { get; set; }
    }
}
