using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandIndirectIsvModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandIndirectIsvModifyModel : AopObject
    {
        /// <summary>
        /// 商户地址信息
        /// </summary>
        [XmlElement("address_info")]
        public AddressInfo AddressInfo { get; set; }

        /// <summary>
        /// 商户简称
        /// </summary>
        [XmlElement("alias_name")]
        public string AliasName { get; set; }

        /// <summary>
        /// 商户证件编号（企业或者个体工商户提供营业执照，事业单位提供事证号）
        /// </summary>
        [XmlElement("business_license")]
        public string BusinessLicense { get; set; }

        /// <summary>
        /// 营业执照，要求营业执照文本信息清晰可见。 请上传照片OSSKey。图片的值为使用ant.merchant.expand.indirect.image.upload上传得到的一串oss key。
        /// </summary>
        [XmlElement("business_license_photo")]
        public string BusinessLicensePhoto { get; set; }

        /// <summary>
        /// 商户证件类型，取值范围：NATIONAL_LEGAL：营业执照；NATIONAL_LEGAL_MERGE:营业执照(多证合一)；INST_RGST_CTF：事业单位法人证书
        /// </summary>
        [XmlElement("business_license_type")]
        public string BusinessLicenseType { get; set; }

        /// <summary>
        /// 商户负责人信息。关键联系人必填。
        /// </summary>
        [XmlElement("contact_info")]
        public ContactInfo ContactInfo { get; set; }

        /// <summary>
        /// 标准商户类别码，例如5976表示“专业销售-药品医疗-康复和身体辅助用品”，银联网联调用时必传
        /// </summary>
        [XmlElement("mcc")]
        public string Mcc { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商户客服电话
        /// </summary>
        [XmlElement("service_phone")]
        public string ServicePhone { get; set; }

        /// <summary>
        /// 商户在支付宝入驻成功后，生成的支付宝内全局唯一的商户编号
        /// </summary>
        [XmlElement("sub_merchant_id")]
        public string SubMerchantId { get; set; }
    }
}
