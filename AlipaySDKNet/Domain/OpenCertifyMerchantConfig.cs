using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenCertifyMerchantConfig Data Structure.
    /// </summary>
    [Serializable]
    public class OpenCertifyMerchantConfig : AopObject
    {
        /// <summary>
        /// 用于开放认证授权
        /// </summary>
        [XmlElement("auth_scope")]
        public string AuthScope { get; set; }

        /// <summary>
        /// 用于指定授权类型，与auth_scope配合使用
        /// </summary>
        [XmlElement("auth_type")]
        public string AuthType { get; set; }

        /// <summary>
        /// 不传默认为reserve
        /// </summary>
        [XmlElement("face_reserve_strategy")]
        public string FaceReserveStrategy { get; set; }

        /// <summary>
        /// 若有特殊人脸等级采集要求，可指定等级
        /// </summary>
        [XmlElement("facial_picture_level")]
        public string FacialPictureLevel { get; set; }

        /// <summary>
        /// 用于授权二级商户操作
        /// </summary>
        [XmlElement("linked_merchant_app_id")]
        public string LinkedMerchantAppId { get; set; }

        /// <summary>
        /// 用于指定展示的商户logo
        /// </summary>
        [XmlElement("linked_merchant_logo_url")]
        public string LinkedMerchantLogoUrl { get; set; }

        /// <summary>
        /// 用于指定展示的商户名称
        /// </summary>
        [XmlElement("linked_merchant_name")]
        public string LinkedMerchantName { get; set; }

        /// <summary>
        /// 在拥有该权限前提下，用于商户控制是否透出活体人脸
        /// </summary>
        [XmlElement("out_put_facial_picture")]
        public bool OutPutFacialPicture { get; set; }

        /// <summary>
        /// 认证成功后需要跳转的地址，一般为商户业务页面；若无跳转地址可填空字符"";
        /// </summary>
        [XmlElement("return_url")]
        public string ReturnUrl { get; set; }
    }
}
