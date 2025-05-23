using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandShopQueryResponse.
    /// </summary>
    public class AntMerchantExpandShopQueryResponse : AopResponse
    {
        /// <summary>
        /// 门店地址库 ID，按照一定的平台规则识别出的线下真实存在、真实经营的蚂蚁门店地址库 ID，将作用于服务商的返佣激励、商品/券等权益的公域分发。如平台未返回alipay_poiid，请在确认门店信息真实有效后，稍后再进行查询。
        /// </summary>
        [XmlElement("alipay_poiid")]
        public string AlipayPoiid { get; set; }

        /// <summary>
        /// 品牌id
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 经营地址。
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
        /// 营业执照图片url。返回值为一个有访问时限的链接
        /// </summary>
        [XmlElement("cert_image")]
        public string CertImage { get; set; }

        /// <summary>
        /// 营业执照名称，值为营业执照或统一社会信用代码证上的名称。
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，取值范围：201：营业执照；2011:多证合一(统一社会信用代码)。
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 联系人信息。
        /// </summary>
        [XmlArray("contact_infos")]
        [XmlArrayItem("contact_info")]
        public List<ContactInfo> ContactInfos { get; set; }

        /// <summary>
        /// 店铺联系手机
        /// </summary>
        [XmlElement("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 店铺的联系固话
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
        /// 查询门店详情时，如果需要同时返回行业信息，需要设置入参中的need_industry_info=1
        /// </summary>
        [XmlArray("industry_info")]
        [XmlArrayItem("merchant_shop_industry_info")]
        public List<MerchantShopIndustryInfo> IndustryInfo { get; set; }

        /// <summary>
        /// 查询门店详情时，如果需要同时返回行业资质，需要设置入参中的need_industry_license=1
        /// </summary>
        [XmlArray("industry_license")]
        [XmlArrayItem("shop_industry_license")]
        public List<ShopIndustryLicense> IndustryLicense { get; set; }

        /// <summary>
        /// 商户角色id，门店属于哪个商户角色。对于直连开店场景，为商户pid；对于间连开店场景（线上、线下、直付通），为商户smid。
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 法人身份证号。
        /// </summary>
        [XmlElement("legal_cert_no")]
        public string LegalCertNo { get; set; }

        /// <summary>
        /// 法人名称。
        /// </summary>
        [XmlElement("legal_name")]
        public string LegalName { get; set; }

        /// <summary>
        /// 营业执照授权函。返回值为一个有访问时限的链接
        /// </summary>
        [XmlElement("license_auth_letter_image")]
        public string LicenseAuthLetterImage { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 门店营业时间，支持一周7天，支持1天内多时间段
        /// </summary>
        [XmlArray("new_business_time")]
        [XmlArrayItem("complex_business_time")]
        public List<ComplexBusinessTime> NewBusinessTime { get; set; }

        /// <summary>
        /// 新版门店类目标准二级类目code
        /// </summary>
        [XmlElement("new_shop_category")]
        public string NewShopCategory { get; set; }

        /// <summary>
        /// 门头照，返回值为一个有访问时限的链接
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
        /// 场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 结算支付宝账号的登录号
        /// </summary>
        [XmlElement("settle_alipay_logon_id")]
        public string SettleAlipayLogonId { get; set; }

        /// <summary>
        /// 店铺类目，取值参见文件中的三级门店类目<a herf="https://mif-pub.alipayobjects.com/ShopCategory.xlsx"></a>
        /// </summary>
        [XmlElement("shop_category")]
        public string ShopCategory { get; set; }

        /// <summary>
        /// 支付宝侧蚂蚁店铺 id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 当前名称、地址、经纬度信息准确一致，可用于数字化经营场景消费(如商品、券、消费圈等场域的分发)，不影响门店支付结算
        /// </summary>
        [XmlElement("shop_info_status")]
        public string ShopInfoStatus { get; set; }

        /// <summary>
        /// 主要针对医疗行业门店主体类型进件使用，不同门店认证主体需要相应的主体资质证书。  企业营业执照: ENTERPRISE;  事业单位法人证书: INST_RGST_CTF;  民办非企业单位登记证书 PRIVATE_NON_ENTERPRISE
        /// </summary>
        [XmlElement("shop_main_type")]
        public string ShopMainType { get; set; }

        /// <summary>
        /// 店铺名称。
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店不置信推荐信息
        /// </summary>
        [XmlElement("shop_recommend_info")]
        public ShopRecommendInfo ShopRecommendInfo { get; set; }

        /// <summary>
        /// 店铺经营类型
        /// </summary>
        [XmlElement("shop_type")]
        public string ShopType { get; set; }

        /// <summary>
        /// 商户侧门店编号。表示该门店在该商户角色id(直连pid，间连smid)下，由商户自己定义的外部门店编号。若未传入 shop_id  则本参数与与ip_role_id均必填。
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
