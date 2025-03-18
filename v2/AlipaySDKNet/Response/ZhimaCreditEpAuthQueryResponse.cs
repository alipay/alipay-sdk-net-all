using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpAuthQueryResponse.
    /// </summary>
    public class ZhimaCreditEpAuthQueryResponse : AopResponse
    {
        /// <summary>
        /// 统一社会信用代码或营业执照注册号
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 法人身份证号
        /// </summary>
        [XmlElement("legal_person_cert_no")]
        public string LegalPersonCertNo { get; set; }

        /// <summary>
        /// 查询公司的法人姓名
        /// </summary>
        [XmlElement("legal_person_name")]
        public string LegalPersonName { get; set; }

        /// <summary>
        /// 法人手机号
        /// </summary>
        [XmlElement("phone_no")]
        public string PhoneNo { get; set; }
    }
}
