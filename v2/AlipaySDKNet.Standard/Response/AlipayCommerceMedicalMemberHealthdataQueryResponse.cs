using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalMemberHealthdataQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalMemberHealthdataQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户头像
        /// </summary>
        [XmlElement("avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// 是否有设备
        /// </summary>
        [XmlElement("has_device")]
        public bool HasDevice { get; set; }

        /// <summary>
        /// 用户健康情况
        /// </summary>
        [XmlElement("health_condition")]
        public string HealthCondition { get; set; }

        /// <summary>
        /// 用户的昵称
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
