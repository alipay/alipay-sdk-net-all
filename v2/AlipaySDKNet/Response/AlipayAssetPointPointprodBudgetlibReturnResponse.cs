using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAssetPointPointprodBudgetlibReturnResponse.
    /// </summary>
    public class AlipayAssetPointPointprodBudgetlibReturnResponse : AopResponse
    {
        /// <summary>
        /// 预算库回收失败时的错误信息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
