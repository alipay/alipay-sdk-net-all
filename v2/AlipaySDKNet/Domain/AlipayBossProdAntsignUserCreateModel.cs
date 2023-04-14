using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdAntsignUserCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdAntsignUserCreateModel : AopObject
    {
        /// <summary>
        /// 业务方来源系统
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 业务线
        /// </summary>
        [XmlElement("business_line_code")]
        public string BusinessLineCode { get; set; }

        /// <summary>
        /// 用户证件号码
        /// </summary>
        [XmlElement("cert_number")]
        public string CertNumber { get; set; }

        /// <summary>
        /// 场景值
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 租户信息
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }

        /// <summary>
        /// 用户证件类型，   * 个人仅支持：   * CRED_PSN_CH_IDCARD（大陆身份证）   *   * 机构仅支持：   * CRED_ORG_USCC（统一社会信用代码）
        /// </summary>
        [XmlElement("user_cert_type")]
        public string UserCertType { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 用户类型，个人“PERSON”，机构“ORG”
        /// </summary>
        [XmlElement("user_type")]
        public string UserType { get; set; }
    }
}
