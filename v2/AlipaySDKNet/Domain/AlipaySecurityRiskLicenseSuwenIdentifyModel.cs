using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskLicenseSuwenIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskLicenseSuwenIdentifyModel : AopObject
    {
        /// <summary>
        /// 关联上游审核工单id
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 医生资质核验参数
        /// </summary>
        [XmlElement("doctor_license_request")]
        public RcDoctorLicenseRequest DoctorLicenseRequest { get; set; }

        /// <summary>
        /// 调用方名称
        /// </summary>
        [XmlElement("invoke_app_name")]
        public string InvokeAppName { get; set; }

        /// <summary>
        /// 调用方使用token
        /// </summary>
        [XmlElement("invoke_token")]
        public string InvokeToken { get; set; }

        /// <summary>
        /// 资质类型
        /// </summary>
        [XmlElement("license_type")]
        public string LicenseType { get; set; }

        /// <summary>
        /// 请求唯一标识
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 调用场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
