using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAlipaymemberGradeQueryResponse.
    /// </summary>
    public class AlipayUserAlipaymemberGradeQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户会员等级
        /// </summary>
        [XmlElement("grade")]
        public string Grade { get; set; }
    }
}
