using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFinancialnetAuthUserParticipateCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinancialnetAuthUserParticipateCertifyModel : AopObject
    {
        /// <summary>
        /// 进行认证的证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 代表进行认证的证件类型（如：身份证）
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 进行认证的用户姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 进行认证的用户的手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 传入外部商户的名称即可，记录发起认证的用户来自哪一个外部商户
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
