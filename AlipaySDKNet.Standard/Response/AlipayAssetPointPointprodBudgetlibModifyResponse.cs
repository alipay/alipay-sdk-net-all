using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAssetPointPointprodBudgetlibModifyResponse.
    /// </summary>
    public class AlipayAssetPointPointprodBudgetlibModifyResponse : AopResponse
    {
        /// <summary>
        /// 预算库有效期修改失败时的错误信息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
