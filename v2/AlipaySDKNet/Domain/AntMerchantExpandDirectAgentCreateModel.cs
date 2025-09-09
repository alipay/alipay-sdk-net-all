using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandDirectAgentCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandDirectAgentCreateModel : AopObject
    {
        /// <summary>
        /// 实际被商户授权的服务商appId，商户将授权给该appId代商户发起交易。该应用ID需为第三方应用类型。
        /// </summary>
        [XmlElement("auth_app_id")]
        public string AuthAppId { get; set; }

        /// <summary>
        /// 营业执照法人支付宝账号对应的手机号
        /// </summary>
        [XmlElement("business_license_mobile")]
        public string BusinessLicenseMobile { get; set; }

        /// <summary>
        /// 营业执照号码
        /// </summary>
        [XmlElement("business_license_no")]
        public string BusinessLicenseNo { get; set; }

        /// <summary>
        /// 营业执照图片，需使用图片上传接口返回的image_id，图片最小5KB ，最大5M（暂不限制图片宽高）。
        /// </summary>
        [XmlElement("business_license_pic")]
        public string BusinessLicensePic { get; set; }

        /// <summary>
        /// 商户联系人信息，包含联系人名称、手机、邮箱信息。联系人信息将用于接受进件的重要通知，如确认协议等。
        /// </summary>
        [XmlElement("contact_info")]
        public MerchantContact ContactInfo { get; set; }

        /// <summary>
        /// 营业期限，非长期有效营业执照的营业截止日期，需yyyy-mm-dd格式
        /// </summary>
        [XmlElement("date_limitation")]
        public string DateLimitation { get; set; }

        /// <summary>
        /// 商户在服务商处的唯一id，每个外部商户号只能进件成功一次
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 商机线索，每个商机线索只能在进件失败时可以复用
        /// </summary>
        [XmlElement("leads_id")]
        public string LeadsId { get; set; }

        /// <summary>
        /// 营业期限是否长期有效
        /// </summary>
        [XmlElement("long_term")]
        public bool LongTerm { get; set; }

        /// <summary>
        /// 参见<a href="https://opendocs.alipay.com/common/02khjv">商家经营类目2.0</a>中的“一级类目code_二级类目code”。
        /// </summary>
        [XmlElement("mcc_code")]
        public string MccCode { get; set; }

        /// <summary>
        /// 商户支付宝账号，一般为手机号或邮箱
        /// </summary>
        [XmlElement("merchant_account")]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// 服务商侧申请单号ID，每次申请都需保持唯一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 店铺地址
        /// </summary>
        [XmlElement("shop_address")]
        public DirectAddressInfo ShopAddress { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺内景图片
        /// </summary>
        [XmlElement("shop_scene_pic")]
        public string ShopScenePic { get; set; }

        /// <summary>
        /// 店铺门头照图片
        /// </summary>
        [XmlElement("shop_sign_board_pic")]
        public string ShopSignBoardPic { get; set; }

        /// <summary>
        /// 企业特殊资质图片，可参考<a href="https://opendocs.alipay.com/common/02khjv">商家经营类目2.0</a>中的“所需资质”。需使用图片上传接口返回的image_id，图片最小5KB ，最大5M（暂不限制图片宽高）。
        /// </summary>
        [XmlElement("special_license_pic")]
        public string SpecialLicensePic { get; set; }
    }
}
