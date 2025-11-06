using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCircularAgreementQueryResponse.
    /// </summary>
    public class AlipayCircularAgreementQueryResponse : AopResponse
    {
        /// <summary>
        /// 扣款账户绑定关系
        /// </summary>
        [XmlElement("relations")]
        public CircularAgreementRelation Relations { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
