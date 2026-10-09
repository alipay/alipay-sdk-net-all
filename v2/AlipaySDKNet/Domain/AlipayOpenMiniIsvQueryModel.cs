using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniIsvQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniIsvQueryModel : AopObject
    {
        /// <summary>
        /// 服务商代商家创建小程序，由支付宝开放平台返回的订单号用于后续查询处理进展。
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
