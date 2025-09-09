using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalOrderConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalOrderConfirmModel : AopObject
    {
        /// <summary>
        /// 订单ID
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
