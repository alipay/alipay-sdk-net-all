using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateStucodeUserQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateStucodeUserQueryResponse : AopResponse
    {
        /// <summary>
        /// 学籍档案
        /// </summary>
        [XmlElement("archive")]
        public StuStatusArchive Archive { get; set; }

        /// <summary>
        /// 是否通过学生认证
        /// </summary>
        [XmlElement("stu_certify")]
        public bool StuCertify { get; set; }
    }
}
