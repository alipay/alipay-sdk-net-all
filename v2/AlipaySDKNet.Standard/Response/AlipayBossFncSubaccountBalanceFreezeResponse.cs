using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncSubaccountBalanceFreezeResponse.
    /// </summary>
    public class AlipayBossFncSubaccountBalanceFreezeResponse : AopResponse
    {
        /// <summary>
        /// 子户余额冻结结果open api数据传输对象
        /// </summary>
        [XmlElement("result_set")]
        public SubAccountBalanceFreezeResultOpenApiDTO ResultSet { get; set; }
    }
}
