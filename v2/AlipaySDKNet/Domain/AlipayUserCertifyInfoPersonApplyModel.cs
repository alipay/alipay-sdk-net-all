using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserCertifyInfoPersonApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCertifyInfoPersonApplyModel : AopObject
    {
        /// <summary>
        /// 用户详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 用于识别是哪个业务来源
        /// </summary>
        [XmlElement("biz_from")]
        public string BizFrom { get; set; }

        /// <summary>
        /// 证件过期时间
        /// </summary>
        [XmlElement("cert_expired_date")]
        public string CertExpiredDate { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型,例如身份证类型是IDENTITY_CARD
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 证件ID，标识证件档案中心的一次采集流水ID
        /// </summary>
        [XmlElement("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 用户住址的城市名称
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 国家信息
        /// </summary>
        [XmlElement("country")]
        public string Country { get; set; }

        /// <summary>
        /// 证件人像页图片SFS地址
        /// </summary>
        [XmlElement("face_url")]
        public string FaceUrl { get; set; }

        /// <summary>
        /// 用户联系手机号码
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 用户在应用（AppId）下的用户唯一标识。
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户地址的省份信息
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 男性：m,女性：f
        /// </summary>
        [XmlElement("sex")]
        public string Sex { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 国微页图片SFS地址，如果非身份证类型，可不必传(例如护照，没有此页)
        /// </summary>
        [XmlElement("verso_url")]
        public string VersoUrl { get; set; }
    }
}
