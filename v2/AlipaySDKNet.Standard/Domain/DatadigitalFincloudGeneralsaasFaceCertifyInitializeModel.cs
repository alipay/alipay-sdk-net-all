using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasFaceCertifyInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudGeneralsaasFaceCertifyInitializeModel : AopObject
    {
        /// <summary>
        /// H5人脸核身场景码。入参支持的场景码。
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 自定义人脸比对图片的base64编码格式的string字符串
        /// </summary>
        [XmlElement("face_contrast_picture")]
        public string FaceContrastPicture { get; set; }

        /// <summary>
        /// 需要验证的身份信息(json)字段说明如下： identity_type： 身份信息参数类型，固定为 CERT_INFO cert_name：真实姓名，必填 cert_no：证件号码，必填 phone_no：手机号码，选填 cert_type：证件类型，必填，枚举支持： IDENTITY_CARD：身份证
        /// </summary>
        [XmlElement("identity_param")]
        public string IdentityParam { get; set; }

        /// <summary>
        /// 商户个性化配置，格式为json，详细支持的字段说明为： return_url：需要回跳的目标地址，必填，一般指定为商户业务页面 face_reserve_strategy：人脸保存策略，非必填；reserve(保存活体人脸)/never(不保存活体人脸)，不传默认为reserve
        /// </summary>
        [XmlElement("merchant_config")]
        public string MerchantConfig { get; set; }

        /// <summary>
        /// 商户请求的唯一标识，商户要保证其唯一性，值为32位长度的字母数字组合。建议：前面几位字符是商户自定义的简称，中间可以使用一段时间，后段可以使用一个随机或递增序列
        /// </summary>
        [XmlElement("outer_order_no")]
        public string OuterOrderNo { get; set; }
    }
}
