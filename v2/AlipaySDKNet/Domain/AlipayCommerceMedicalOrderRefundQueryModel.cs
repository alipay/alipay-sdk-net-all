using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalOrderRefundQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalOrderRefundQueryModel : AopObject
    {
        /// <summary>
        /// 订单编号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
