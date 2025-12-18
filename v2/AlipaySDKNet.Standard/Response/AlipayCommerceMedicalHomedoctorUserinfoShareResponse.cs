using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHomedoctorUserinfoShareResponse.
    /// </summary>
    public class AlipayCommerceMedicalHomedoctorUserinfoShareResponse : AopResponse
    {
        /// <summary>
        /// 用户对外开放openid
        /// </summary>
        [XmlElement("aq_open_id")]
        public string AqOpenId { get; set; }

        /// <summary>
        /// 用户证件姓名
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 居民身份证
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 人脸认证单据号
        /// </summary>
        [XmlElement("certify_id")]
        public string CertifyId { get; set; }

        /// <summary>
        /// 人脸认证状态：PROCESSING：初始化；SUCCESS：认证通过；FAIL：认证不通过
        /// </summary>
        [XmlElement("certify_state")]
        public string CertifyState { get; set; }

        /// <summary>
        /// 用户手机号码
        /// </summary>
        [XmlElement("mobile_phone")]
        public string MobilePhone { get; set; }
    }
}
