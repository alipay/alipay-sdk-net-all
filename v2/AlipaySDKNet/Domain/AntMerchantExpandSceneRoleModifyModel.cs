using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandSceneRoleModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandSceneRoleModifyModel : AopObject
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
        /// 类目,按照场景要求传参
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
        /// 场景关联的2088
        /// </summary>
        [XmlElement("master_partner_id")]
        public string MasterPartnerId { get; set; }

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
