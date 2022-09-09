using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneEcommerceTradeeventSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneEcommerceTradeeventSyncModel : AopObject
    {
        /// <summary>
        /// 买家
        /// </summary>
        [XmlElement("buyer")]
        public EcomBuyerDTO Buyer { get; set; }

        /// <summary>
        /// 事件类型:ECOM_SHIPPED_DONE  发货,ECOM_BUYER_CONFIRM  确认收货,
        /// </summary>
        [XmlElement("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// 指定保险受理凭证
        /// </summary>
        [XmlArray("insure_certificates")]
        [XmlArrayItem("insure_certificate_d_t_o")]
        public List<InsureCertificateDTO> InsureCertificates { get; set; }

        /// <summary>
        /// 商品
        /// </summary>
        [XmlElement("item")]
        public EcomItemDTO Item { get; set; }

        /// <summary>
        /// 订单
        /// </summary>
        [XmlElement("order_dto")]
        public EcomOrderDTO OrderDto { get; set; }

        /// <summary>
        /// 合作商标识
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 卖家
        /// </summary>
        [XmlElement("seller")]
        public EcomSellerDTO Seller { get; set; }
    }
}
