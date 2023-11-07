using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoCityserviceMessageQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCityserviceMessageQueryModel : AopObject
    {
        /// <summary>
        /// 传入值为支付宝uid； 机构配置传入类型为支付宝uid时，必填； alipay_user_id优先级高于(certificate_number/certificate_username) 和 mobile，若不为空则以alipay_user_id为准作为用户身份
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 证件号码. 机构配置用户信息为 身份证+姓名或者身份证时，且未传入 alipay_user_id时必填 该字段为敏感字段，须做md5或sm3处理后传输。示例中值的明文为310101198011110010.
        /// </summary>
        [XmlElement("certificate_number")]
        public string CertificateNumber { get; set; }

        /// <summary>
        /// 证件类型 01标识身份证
        /// </summary>
        [XmlElement("certificate_type")]
        public string CertificateType { get; set; }

        /// <summary>
        /// 证件用户名字. 机构配置用户信息为证件号+证件姓名且alipay_user_id为空时必填
        /// </summary>
        [XmlElement("certificate_username")]
        public string CertificateUsername { get; set; }

        /// <summary>
        /// 加密类型：md5,sm3.
        /// </summary>
        [XmlElement("encrypt_type")]
        public string EncryptType { get; set; }

        /// <summary>
        /// 机构配置用户信息为 手机号时，且未传入 alipay_user_id时必填
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// certificate_type/certificate_number/用户名字) 或者 open_id 必须有一个不为空。两个都不为空则以open_id为准
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 机构已发送的消息唯一编号(APPID下唯一)。
        /// </summary>
        [XmlElement("uuid")]
        public string Uuid { get; set; }
    }
}
