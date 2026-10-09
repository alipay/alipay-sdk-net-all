using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarRentalMerchantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CarRentalMerchantInfo : AopObject
    {
        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 品牌统一的服务电话
        /// </summary>
        [XmlElement("merchant_contact")]
        public string MerchantContact { get; set; }

        /// <summary>
        /// 直连商户id
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 间联商户
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
