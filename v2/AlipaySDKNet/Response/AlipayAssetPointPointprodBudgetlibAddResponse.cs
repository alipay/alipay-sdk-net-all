using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAssetPointPointprodBudgetlibAddResponse.
    /// </summary>
    public class AlipayAssetPointPointprodBudgetlibAddResponse : AopResponse
    {
        /// <summary>
        /// 当order_no发生幂等时返回的错误信息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
