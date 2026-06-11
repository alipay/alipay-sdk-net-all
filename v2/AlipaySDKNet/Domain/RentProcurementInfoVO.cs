using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentProcurementInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentProcurementInfoVO : AopObject
    {
        /// <summary>
        /// 关联租赁采购单id
        /// </summary>
        [XmlElement("procurement_order_id")]
        public string ProcurementOrderId { get; set; }
    }
}
