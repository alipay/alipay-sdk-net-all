using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemVoucherQueryDisplayPatternInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemVoucherQueryDisplayPatternInfo : AopObject
    {
        /// <summary>
        /// 客服电话
        /// </summary>
        [XmlElement("customer_service_mobile")]
        public string CustomerServiceMobile { get; set; }

        /// <summary>
        /// 券描述信息
        /// </summary>
        [XmlElement("voucher_description")]
        public string VoucherDescription { get; set; }
    }
}
