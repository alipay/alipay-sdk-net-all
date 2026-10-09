using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreComplianceTemplateInstancecomponentCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreComplianceTemplateInstancecomponentCertifyModel : AopObject
    {
        /// <summary>
        /// 组件编码
        /// </summary>
        [XmlElement("component_code")]
        public string ComponentCode { get; set; }

        /// <summary>
        /// 域账号名称
        /// </summary>
        [XmlElement("domain_name")]
        public string DomainName { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [XmlElement("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 业务系统分配的密令，找系统owner获取
        /// </summary>
        [XmlElement("secret")]
        public string Secret { get; set; }

        /// <summary>
        /// 来源系统id
        /// </summary>
        [XmlElement("source_system_id")]
        public string SourceSystemId { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        [XmlElement("work_no")]
        public string WorkNo { get; set; }
    }
}
