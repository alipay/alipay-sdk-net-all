using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandShopModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandShopModifyModel : AopObject
    {
        /// <summary>
        /// "门店结算卡信息。本业务当前只允许传入一张结算卡。 说明：本参数仅直付通业务使用，其余业务无需关注。"
        /// </summary>
        [XmlArray("biz_cards")]
        [XmlArrayItem("settle_card_info")]
        public List<SettleCardInfo> BizCards { get; set; }

        /// <summary>
        /// 品牌id。若无需更新本信息项，可以不填写。可以从B/P站品牌工具箱获取品牌id
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 经营地址。若填写本对象，其中省、市、区、地址必填，其余选填。无需更新本信息项时请整体留空，如有填写将整体覆盖本信息项
        /// </summary>
        [XmlElement("business_address")]
        public AddressInfo BusinessAddress { get; set; }

        /// <summary>
        /// 店铺经营时间。若无需更新本信息项，可以不填写
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
        /// 证件号码。请填写店铺营业执照号。
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 联系人信息。如果填写，其中名称必填，手机、固话、email三选一必填。填写则会将本信息项整体更新，覆盖原有的所有联系人
        /// </summary>
        [XmlElement("contact_infos")]
        public ContactInfo ContactInfos { get; set; }

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
        /// 封面图，其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。若无需更新本信息项，可以不填写。若填写则会整体覆盖原有的封面图
        /// </summary>
        [XmlElement("cover")]
        public string Cover { get; set; }

        /// <summary>
        /// 扩展信息列表。key值需要向对应行业的bd进行申请。传入本项时，按key进行更新或补充
        /// </summary>
        [XmlArray("ext_infos")]
        [XmlArrayItem("shop_ext_info")]
        public List<ShopExtInfo> ExtInfos { get; set; }

        /// <summary>
        /// 行业信息，例如所属集团、特殊标签
        /// </summary>
        [XmlArray("industry_info")]
        [XmlArrayItem("merchant_shop_industry_info")]
        public List<MerchantShopIndustryInfo> IndustryInfo { get; set; }

        /// <summary>
        /// 门店资质信息
        /// </summary>
        [XmlArray("industry_license")]
        [XmlArrayItem("shop_industry_license")]
        public List<ShopIndustryLicense> IndustryLicense { get; set; }

        /// <summary>
        /// 商户角色id，表示将要修改的店属于哪个商户角色，和store_id一起定位待修改的门店。对于直连场景，填写商户pid；对于间连场景（线上、线下、直付通），填写商户smid。本信息项不可修改
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 法人身份证号。如果要更新，必须和legal_name成对传入
        /// </summary>
        [XmlElement("legal_cert_no")]
        public string LegalCertNo { get; set; }

        /// <summary>
        /// 法人名称。如果要更新，必须和legal_cert_no成对传入
        /// </summary>
        [XmlElement("legal_name")]
        public string LegalName { get; set; }

        /// <summary>
        /// 营业执照授权函。其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。若无需更新本信息项，可以不填写
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
        /// 门头照，其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。若无需更新本信息项，可以不填写。若填写则会整体覆盖原有的门头照列表
        /// </summary>
        [XmlArray("out_door_images")]
        [XmlArrayItem("string")]
        public List<string> OutDoorImages { get; set; }

        /// <summary>
        /// 行业特殊资质。若无需更新本信息项，可以不填写。填写会按类型进行更新或补充
        /// </summary>
        [XmlArray("qualifications")]
        [XmlArrayItem("industry_qualification_info")]
        public List<IndustryQualificationInfo> Qualifications { get; set; }

        /// <summary>
        /// 场景。若无需更新本信息项，可以不填写
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 结算支付宝账号的登录号。若无需更新本信息项，可以不填写
        /// </summary>
        [XmlElement("settle_alipay_logon_id")]
        public string SettleAlipayLogonId { get; set; }

        /// <summary>
        /// 新版门店类目标准二级类目code。类目标准及与原类目映射关系参见 <a href="https://gw.alipayobjects.com/os/bmw-prod/4b3f82df-e53e-4b84-bc41-fe025101e726.xlsx">支付宝门店类目-最新</a> 表格。
        /// </summary>
        [XmlElement("shop_category")]
        public string ShopCategory { get; set; }

        /// <summary>
        /// 蚂蚁店铺id，用于查出待修改的门店。填写本参数的话，store_id和ip_role_id可以不填。本信息项不可修改
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 主要针对医疗行业门店主体类型进件使用，不同门店认证主体需要相应的主体资质证书。  企业营业执照: ENTERPRISE;  事业单位法人证书: INST_RGST_CTF;  民办非企业单位登记证书 PRIVATE_NON_ENTERPRISE
        /// </summary>
        [XmlElement("shop_main_type")]
        public string ShopMainType { get; set; }

        /// <summary>
        /// 店铺名称。直连开店要保证全局店铺名称+地址唯一，间连开店要保证服务商pid下店铺名称+地址唯一。若无需更新本信息项，可以不填写
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店编号，表示该门店在该商户角色id(直连pid，间连smid)下，由商户自己定义的外部门店编号。用于查出待修改的门店。
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
