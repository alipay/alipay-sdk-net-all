using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSearchAbilityBatchqueryResponse.
    /// </summary>
    public class AlipayOpenSearchAbilityBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 搜索运营分页数据
        /// </summary>
        [XmlElement("data")]
        public AbilityPageQueryDTO Data { get; set; }
    }
}
