using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalOrderDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalOrderDetailQueryModel : AopObject
    {
        /// <summary>
        /// 订单编号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
