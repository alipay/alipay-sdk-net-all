using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcCreditWithdrawDisburseResponse.
    /// </summary>
    public class AlipayCommerceEcCreditWithdrawDisburseResponse : AopResponse
    {
        /// <summary>
        /// 成功: SUCCESS 失败: FAIL
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
