using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcCreditApproveResponse.
    /// </summary>
    public class AlipayCommerceEcCreditApproveResponse : AopResponse
    {
        /// <summary>
        /// 结果 成功: SUCCESS 失败: FAIL
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
