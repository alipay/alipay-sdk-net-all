using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalmgmtHrhealthKdysPersoninfoQueryResponse.
    /// </summary>
    public class AlipayDigitalmgmtHrhealthKdysPersoninfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 出生日期，yyyy-MM-dd格式
        /// </summary>
        [XmlElement("birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型对应的枚举值，对应关系见枚举值描述
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 人员姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 人员类型，对应关系见枚举值，若枚举值不匹配则为不享有服务
        /// </summary>
        [XmlElement("person_type")]
        public string PersonType { get; set; }

        /// <summary>
        /// 性别，对应关系见枚举值
        /// </summary>
        [XmlElement("sex")]
        public string Sex { get; set; }

        /// <summary>
        /// 钉钉unionId，唯一用户标识
        /// </summary>
        [XmlElement("union_id")]
        public string UnionId { get; set; }

        /// <summary>
        /// 钉钉userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
