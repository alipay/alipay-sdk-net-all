using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdStocktaskCreateResponse.
    /// </summary>
    public class AlipayCommerceTransportAdStocktaskCreateResponse : AopResponse
    {
        /// <summary>
        /// 库存查询任务id +  库存查询任务的唯一标识，可使用该ID进行库存任务详情查询
        /// </summary>
        [XmlElement("task_id")]
        public long TaskId { get; set; }
    }
}
