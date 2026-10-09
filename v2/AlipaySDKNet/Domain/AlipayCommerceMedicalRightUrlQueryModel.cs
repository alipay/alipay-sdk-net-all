using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalRightUrlQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalRightUrlQueryModel : AopObject
    {
        /// <summary>
        /// 履约单号
        /// </summary>
        [XmlElement("fulfillment_no")]
        public string FulfillmentNo { get; set; }

        /// <summary>
        /// 服务项id
        /// </summary>
        [XmlElement("service_item_id")]
        public string ServiceItemId { get; set; }

        /// <summary>
        /// 服务包订单号
        /// </summary>
        [XmlElement("service_package_order_no")]
        public string ServicePackageOrderNo { get; set; }
    }
}
