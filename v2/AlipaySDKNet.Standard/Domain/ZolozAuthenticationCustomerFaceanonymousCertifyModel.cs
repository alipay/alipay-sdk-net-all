using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZolozAuthenticationCustomerFaceanonymousCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZolozAuthenticationCustomerFaceanonymousCertifyModel : AopObject
    {
        /// <summary>
        /// 活体照片的二进制内容，然后做base64编码
        /// </summary>
        [XmlElement("auth_img")]
        public string AuthImg { get; set; }

        /// <summary>
        /// 活体图片采集方式，例如C0代表手机端采集的人脸图片 。C1代表机具端采集的人脸图片
        /// </summary>
        [XmlElement("auth_img_source")]
        public string AuthImgSource { get; set; }

        /// <summary>
        /// 只允许数字加字母，商户请求的唯一标志，该标识作为对账的关键信息，商户要保证其唯一性
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务方使用的账户唯一标示
        /// </summary>
        [XmlElement("merchant_uid")]
        public string MerchantUid { get; set; }
    }
}
