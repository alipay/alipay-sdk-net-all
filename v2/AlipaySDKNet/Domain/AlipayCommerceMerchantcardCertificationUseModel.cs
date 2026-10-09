using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardCertificationUseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardCertificationUseModel : AopObject
    {
        /// <summary>
        /// 核销信息
        /// </summary>
        [XmlArray("certificate_use_info_list")]
        [XmlArrayItem("merchant_certificate_use_info")]
        public List<MerchantCertificateUseInfo> CertificateUseInfoList { get; set; }

        /// <summary>
        /// 核销门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
