using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHmServiceitemQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHmServiceitemQueryModel : AopObject
    {
        /// <summary>
        /// 服务包订单ID。通过履约单号换取服务订单id
        /// </summary>
        [XmlElement("package_order_id")]
        public string PackageOrderId { get; set; }
    }
}
