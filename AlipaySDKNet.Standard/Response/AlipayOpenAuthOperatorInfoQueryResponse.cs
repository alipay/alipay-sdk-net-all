using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAuthOperatorInfoQueryResponse.
    /// </summary>
    public class AlipayOpenAuthOperatorInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 操作员基础信息
        /// </summary>
        [XmlElement("operator_info")]
        public OperatorBasicInfo OperatorInfo { get; set; }
    }
}
