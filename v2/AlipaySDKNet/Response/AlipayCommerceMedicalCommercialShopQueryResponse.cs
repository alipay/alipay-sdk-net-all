using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalCommercialShopQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalCommercialShopQueryResponse : AopResponse
    {
        /// <summary>
        /// 广申表
        /// </summary>
        [XmlElement("advertise_service_cert")]
        public string AdvertiseServiceCert { get; set; }

        /// <summary>
        /// 门店地址
        /// </summary>
        [XmlElement("business_address")]
        public ShopBusinessAddress BusinessAddress { get; set; }

        /// <summary>
        /// 证件照片
        /// </summary>
        [XmlElement("cert_image")]
        public string CertImage { get; set; }

        /// <summary>
        /// 门店logo
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 门店属性
        /// </summary>
        [XmlArray("medical_level_tags")]
        [XmlArrayItem("string")]
        public List<string> MedicalLevelTags { get; set; }

        /// <summary>
        /// 医疗许可证
        /// </summary>
        [XmlElement("medical_service_cert")]
        public string MedicalServiceCert { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 商家PID
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 蚂蚁门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 门店照片
        /// </summary>
        [XmlArray("shop_images")]
        [XmlArrayItem("string")]
        public List<string> ShopImages { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }
    }
}
