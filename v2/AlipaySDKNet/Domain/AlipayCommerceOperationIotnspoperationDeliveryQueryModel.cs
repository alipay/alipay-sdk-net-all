using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationIotnspoperationDeliveryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationIotnspoperationDeliveryQueryModel : AopObject
    {
        /// <summary>
        /// 枚举值： ·SELF_MODE 商户自接入模式 ·AGENCY_MODE 服务商代接入模式
        /// </summary>
        [XmlElement("merchant_access_mode")]
        public string MerchantAccessMode { get; set; }

        /// <summary>
        /// 碰一下推广计划id
        /// </summary>
        [XmlElement("n_delivery_id")]
        public string NDeliveryId { get; set; }
    }
}
