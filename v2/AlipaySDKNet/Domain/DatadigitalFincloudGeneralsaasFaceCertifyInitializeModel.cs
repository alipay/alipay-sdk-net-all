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
        /// 需要验证的身份信息
        /// </summary>
        [XmlElement("identity_param")]
        public OpenCertifyIdentifyInfo IdentityParam { get; set; }

        /// <summary>
        /// 商户个性化配置信息
        /// </summary>
        [XmlElement("merchant_config")]
        public OpenCertifyMerchantConfigs MerchantConfig { get; set; }

        /// <summary>
        /// 商户请求的唯一标识，商户要保证其唯一性，值为32位长度的字母数字组合。建议：前面几位字符是商户自定义的简称，中间可以使用一段时间，后段可以使用一个随机或递增序列
        /// </summary>
        [XmlElement("outer_order_no")]
        public string OuterOrderNo { get; set; }
    }
}
