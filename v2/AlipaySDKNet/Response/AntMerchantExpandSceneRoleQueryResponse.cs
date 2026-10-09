using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandSceneRoleQueryResponse.
    /// </summary>
    public class AntMerchantExpandSceneRoleQueryResponse : AopResponse
    {
        /// <summary>
        /// 商户别名
        /// </summary>
        [XmlElement("alias_name")]
        public string AliasName { get; set; }

        /// <summary>
        /// 经营地址
        /// </summary>
        [XmlElement("business_address")]
        public AddressInfo BusinessAddress { get; set; }

        /// <summary>
        /// 类目，场景接入前咨询
        /// </summary>
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 联系人信息及证照信息
        /// </summary>
        [XmlElement("contact_persons")]
        public MerchantContactPerson ContactPersons { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("contact_phones")]
        [XmlArrayItem("string")]
        public List<string> ContactPhones { get; set; }

        /// <summary>
        /// 商户编号，由调用方定义，需要保证在调用方下唯一
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 法人证照信息
        /// </summary>
        [XmlElement("legal_info")]
        public MerchantCertificateInfo LegalInfo { get; set; }

        /// <summary>
        /// 主体证照信息
        /// </summary>
        [XmlElement("license_info")]
        public MerchantCertificateInfo LicenseInfo { get; set; }

        /// <summary>
        /// 主合作伙伴ID
        /// </summary>
        [XmlElement("master_partner_id")]
        public string MasterPartnerId { get; set; }

        /// <summary>
        /// 商户类型，01：企业；license_info.cert_type填写201（营业执照）；license_info.cert_no填写营业执照号； 02：事业单位：license_info.cert_type填写218（事业单位法人证书）；license_info.cert_no填写事业单位法人证书编号； 03：民办非企业组织：license_info.cert_type填写204（民办非企业登记证书）；license_info.cert_no填写民办非企业登记证书编号； 04：社会团体：license_info.cert_type填写206（社会团体法人登记证书）；license_info.cert_no填写社会团体法人登记证书编号； 05：党政及国家机关：license_info.cert_type填写219（党政机关批准设立文件/行政执法主体资格证）；license_info.cert_no填写党政机关批准设立文件/行政执法主体资格证编号； 06：个人商户：license_info.cert_type填写100（个人身份证）；license_info.cert_no填写个人身份证号码； 07：个体工商户：license_info.cert_type填写201（营业执照）；license_info.cert_no填写营业执照编号；
        /// </summary>
        [XmlElement("merchant_type")]
        public string MerchantType { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 图片通过通过 ant.merchant.expand.indirect.image.upload 接口上传图片后得到的 image_id
        /// </summary>
        [XmlElement("out_door_pic")]
        public string OutDoorPic { get; set; }

        /// <summary>
        /// 合作伙伴id
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("service_phones")]
        [XmlArrayItem("string")]
        public List<string> ServicePhones { get; set; }

        /// <summary>
        /// 结算用支付宝账号
        /// </summary>
        [XmlElement("settle_alipay_logon_id")]
        public string SettleAlipayLogonId { get; set; }
    }
}
