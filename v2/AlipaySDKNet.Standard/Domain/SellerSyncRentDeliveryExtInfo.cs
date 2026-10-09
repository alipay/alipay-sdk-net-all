using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SellerSyncRentDeliveryExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SellerSyncRentDeliveryExtInfo : AopObject
    {
        /// <summary>
        /// 物流公司的物流单号，例如：顺丰的物流单号
        /// </summary>
        [XmlElement("delivery_no")]
        public string DeliveryNo { get; set; }

        /// <summary>
        /// 收货地址
        /// </summary>
        [XmlElement("receive_address")]
        public RentAddress ReceiveAddress { get; set; }
    }
}
