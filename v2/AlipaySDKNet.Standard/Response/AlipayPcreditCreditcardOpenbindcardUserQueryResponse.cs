using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditCreditcardOpenbindcardUserQueryResponse.
    /// </summary>
    public class AlipayPcreditCreditcardOpenbindcardUserQueryResponse : AopResponse
    {
        /// <summary>
        /// 活动是否对查询用户准入
        /// </summary>
        [XmlElement("admit")]
        public string Admit { get; set; }

        /// <summary>
        /// 查询用户是否已经完成过活动
        /// </summary>
        [XmlElement("completed_activity")]
        public string CompletedActivity { get; set; }
    }
}
