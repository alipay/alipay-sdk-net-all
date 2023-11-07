using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandShopCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandShopCreateModel : AopObject
    {
        /// <summary>
        /// "门店结算卡信息。本业务当前只允许传入一张结算卡。 说明：本参数仅直付通业务使用，其余业务无需关注。"
        /// </summary>
        [XmlArray("biz_cards")]
        [XmlArrayItem("settle_card_info")]
        public List<SettleCardInfo> BizCards { get; set; }

        /// <summary>
        /// 品牌id，非加油站等特殊门店无需关注。
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 经营地址。地址对象中省、市、区、地址必填，其余选填
        /// </summary>
        [XmlElement("business_address")]
        public AddressInfo BusinessAddress { get; set; }

        /// <summary>
        /// 店铺经营时间。
        /// </summary>
        [XmlArray("business_time")]
        [XmlArrayItem("shop_business_time")]
        public List<ShopBusinessTime> BusinessTime { get; set; }

        /// <summary>
        /// 营业执照图片KEY
        /// </summary>
        [XmlElement("cert_image")]
        public string CertImage { get; set; }

        /// <summary>
        /// 营业执照名称，填写值为营业执照或统一社会信用代码证上的名称。
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号码，请填写店铺营业执照号。
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 联系人信息
        /// </summary>
        [XmlArray("contact_infos")]
        [XmlArrayItem("contact_info")]
        public List<ContactInfo> ContactInfos { get; set; }

        /// <summary>
        /// 店铺联系手机号
        /// </summary>
        [XmlElement("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 店铺的联系固定电话
        /// </summary>
        [XmlElement("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 扩展信息列表。key值需要向对应行业的bd进行申请。
        /// </summary>
        [XmlArray("ext_infos")]
        [XmlArrayItem("shop_ext_info")]
        public List<ShopExtInfo> ExtInfos { get; set; }

        /// <summary>
        /// 当前门店归属的商户角色 ID，表示当前进件的店铺的归属商户。对于直连开店场景，填写商户 PID。对于间连开店场景（线上、线下、直付通），商户SMID
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 法人身份证号
        /// </summary>
        [XmlElement("legal_cert_no")]
        public string LegalCertNo { get; set; }

        /// <summary>
        /// 法人名称
        /// </summary>
        [XmlElement("legal_name")]
        public string LegalName { get; set; }

        /// <summary>
        /// 营业执照授权函图片id，通过 ant.merchant.expand.indirect.image.upload 接口上传图片后得到的 image_id
        /// </summary>
        [XmlElement("license_auth_letter_image")]
        public string LicenseAuthLetterImage { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 门头照 id，需传入<a href="https://opendocs.alipay.com/apis/api_1/ant.merchant.expand.indirect.image.upload">ant.merchant.expand.indirect.image.upload</a> 接口上传图片后得到的 image_id。 通过蚂蚁门店管理能力创建门店时可选。
        /// </summary>
        [XmlArray("out_door_images")]
        [XmlArrayItem("string")]
        public List<string> OutDoorImages { get; set; }

        /// <summary>
        /// 行业特殊资质。
        /// </summary>
        [XmlArray("qualifications")]
        [XmlArrayItem("industry_qualification_info")]
        public List<IndustryQualificationInfo> Qualifications { get; set; }

        /// <summary>
        /// 场景，非加油站/酒店等特殊门店无需关注。
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 门店结算收款的支付宝账号
        /// </summary>
        [XmlElement("settle_alipay_logon_id")]
        public string SettleAlipayLogonId { get; set; }

        /// <summary>
        /// 新版门店类目标准二级类目code。类目标准及与原类目映射关系参见 <a href="https://gw.alipayobjects.com/os/bmw-prod/4b3f82df-e53e-4b84-bc41-fe025101e726.xlsx">支付宝门店类目-最新</a> 表格。
        /// </summary>
        [XmlElement("shop_category")]
        public string ShopCategory { get; set; }

        /// <summary>
        /// 店铺名称, 由商户定义在支付宝内的店铺名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺经营类型，01表示直营，02表示加盟
        /// </summary>
        [XmlElement("shop_type")]
        public string ShopType { get; set; }

        /// <summary>
        /// 门店编号，表示该门店在该商户角色id(直连pid，间连smid)下，由商户自己定义的外部门店编号
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
