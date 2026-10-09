using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceWaterTaskBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceWaterTaskBatchqueryModel : AopObject
    {
        /// <summary>
        /// 商户pid
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }
    }
}
