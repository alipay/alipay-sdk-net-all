using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenDataquerytwoJianhuiQueryResponse.
    /// </summary>
    public class AlipayOpenDataquerytwoJianhuiQueryResponse : AopResponse
    {
        /// <summary>
        /// 复杂类型出参测试一
        /// </summary>
        [XmlElement("czcsone")]
        public CDataJianTestOne Czcsone { get; set; }

        /// <summary>
        /// 消息一
        /// </summary>
        [XmlElement("msgone")]
        public string Msgone { get; set; }
    }
}
