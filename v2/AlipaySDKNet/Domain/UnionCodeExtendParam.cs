using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UnionCodeExtendParam Data Structure.
    /// </summary>
    [Serializable]
    public class UnionCodeExtendParam : AopObject
    {
        /// <summary>
        /// 签约人身份信息
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 外部身份信息类型字符串
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 医保一码付，国家局决策渠道id
        /// </summary>
        [XmlElement("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// ip所在的城市（拼音即可）
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 用户当前的登录IP
        /// </summary>
        [XmlElement("client_ip")]
        public string ClientIp { get; set; }

        /// <summary>
        /// 外部凭证的生码时间 格式：yyyy-MM-dd HH:mm:ss 2024-03-03 20:39:00
        /// </summary>
        [XmlElement("code_create_time")]
        public string CodeCreateTime { get; set; }

        /// <summary>
        /// ip所在的国家
        /// </summary>
        [XmlElement("country")]
        public string Country { get; set; }

        /// <summary>
        /// 当展码人与签约人为同一个人时，填本人；否则填写展码人与签约人的关系，如子女、父母、夫妻、其他（汉字即可）
        /// </summary>
        [XmlElement("exhibit_role")]
        public string ExhibitRole { get; set; }

        /// <summary>
        /// 当展码人与签约人不是同一个人时，填写展码人的证件信息
        /// </summary>
        [XmlElement("exhibit_role_cert_no")]
        public string ExhibitRoleCertNo { get; set; }

        /// <summary>
        /// 外部身份证件类型
        /// </summary>
        [XmlElement("exhibit_role_cert_type")]
        public string ExhibitRoleCertType { get; set; }

        /// <summary>
        /// 当展码人与签约人不是同一个人时，填写展码人的姓名
        /// </summary>
        [XmlElement("exhibit_role_name")]
        public string ExhibitRoleName { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [XmlElement("machine_type")]
        public string MachineType { get; set; }

        /// <summary>
        /// ip所在的省份（拼音即可）
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 签约人姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
