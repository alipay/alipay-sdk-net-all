using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalPrescriptionListQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalPrescriptionListQueryModel : AopObject
    {
        /// <summary>
        /// 订单编号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
