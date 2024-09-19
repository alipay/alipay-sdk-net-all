using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantPaymrchdataQrcodeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantPaymrchdataQrcodeCreateModel : AopObject
    {
        /// <summary>
        /// 商户经营地址
        /// </summary>
        [XmlElement("business_address_info")]
        public MdAddressInfo BusinessAddressInfo { get; set; }

        /// <summary>
        /// 商户证件信息（商户营业执照号、法人身份证号等）
        /// </summary>
        [XmlArray("certificate_infos")]
        [XmlArrayItem("md_certificate_info")]
        public List<MdCertificateInfo> CertificateInfos { get; set; }

        /// <summary>
        /// 联系人信息
        /// </summary>
        [XmlArray("contact_persons")]
        [XmlArrayItem("contact_person")]
        public List<ContactPerson> ContactPersons { get; set; }

        /// <summary>
        /// 调用方外部唯一ID
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 商户mcc信息，mcc模型定义使用调用方的
        /// </summary>
        [XmlElement("mcc_info")]
        public MccInfo MccInfo { get; set; }

        /// <summary>
        /// 开通经营码的店铺名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 门头照链接
        /// </summary>
        [XmlElement("shop_door_pic")]
        public string ShopDoorPic { get; set; }

        /// <summary>
        /// 请求来源，用做权限校验和流水记录
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
