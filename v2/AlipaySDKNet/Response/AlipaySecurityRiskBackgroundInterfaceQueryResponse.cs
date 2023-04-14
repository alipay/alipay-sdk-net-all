using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskBackgroundInterfaceQueryResponse.
    /// </summary>
    public class AlipaySecurityRiskBackgroundInterfaceQueryResponse : AopResponse
    {
        /// <summary>
        /// 背景详细信息：查询到的人物背景信息，包括学历信息、是否涉及诉讼、商业冲突等。
        /// </summary>
        [XmlElement("detail_info")]
        public string DetailInfo { get; set; }
    }
}
