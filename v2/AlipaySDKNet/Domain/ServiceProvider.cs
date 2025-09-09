using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceProvider Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceProvider : AopObject
    {
        /// <summary>
        /// 服务提供者:医生/医助头像
        /// </summary>
        [XmlElement("avatar_url")]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// 服务提供者:外部医生/医助id
        /// </summary>
        [XmlElement("out_doctor_id")]
        public string OutDoctorId { get; set; }

        /// <summary>
        /// 角色类型：医生、医助
        /// </summary>
        [XmlElement("provider_type")]
        public string ProviderType { get; set; }

        /// <summary>
        /// 服务提供者:医生/医助姓名
        /// </summary>
        [XmlElement("service_provider_name")]
        public string ServiceProviderName { get; set; }
    }
}
