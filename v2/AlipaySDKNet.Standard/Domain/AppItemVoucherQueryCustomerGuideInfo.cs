using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemVoucherQueryCustomerGuideInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemVoucherQueryCustomerGuideInfo : AopObject
    {
        /// <summary>
        /// 券核销引导
        /// </summary>
        [XmlElement("app_item_voucher_use_guide_info")]
        public AppItemVoucherQueryUseGuideInfo AppItemVoucherUseGuideInfo { get; set; }
    }
}
