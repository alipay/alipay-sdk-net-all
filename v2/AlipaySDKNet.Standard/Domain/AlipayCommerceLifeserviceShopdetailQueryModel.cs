using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLifeserviceShopdetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLifeserviceShopdetailQueryModel : AopObject
    {
        /// <summary>
        /// 门店主键ID【必填】
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
