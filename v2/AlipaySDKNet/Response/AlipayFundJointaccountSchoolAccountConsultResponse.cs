using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundJointaccountSchoolAccountConsultResponse.
    /// </summary>
    public class AlipayFundJointaccountSchoolAccountConsultResponse : AopResponse
    {
        /// <summary>
        /// 返回学生是否加小荷包，若学生的证件号、姓名等信息不匹配则返回false
        /// </summary>
        [XmlElement("has_registered")]
        public bool HasRegistered { get; set; }
    }
}
