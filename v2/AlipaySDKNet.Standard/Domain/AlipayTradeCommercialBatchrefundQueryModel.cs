using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeCommercialBatchrefundQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeCommercialBatchrefundQueryModel : AopObject
    {
        /// <summary>
        /// 批量退款请求单号
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }
    }
}
