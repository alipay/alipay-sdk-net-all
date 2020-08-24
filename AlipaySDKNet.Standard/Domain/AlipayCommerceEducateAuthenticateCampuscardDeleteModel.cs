using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateAuthenticateCampuscardDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateAuthenticateCampuscardDeleteModel : AopObject
    {
        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 学生证件类型，默认为1: 1 居民身份证
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 学校国标码
        /// </summary>
        [XmlElement("school_stdcode")]
        public string SchoolStdcode { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
