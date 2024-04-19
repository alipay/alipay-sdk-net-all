using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIndirectmerchantBusinessstatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIndirectmerchantBusinessstatusModifyModel : AopObject
    {
        /// <summary>
        /// 商家经营状态
        /// </summary>
        [XmlElement("business_status")]
        public string BusinessStatus { get; set; }

        /// <summary>
        /// 商户Pid
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }
    }
}
