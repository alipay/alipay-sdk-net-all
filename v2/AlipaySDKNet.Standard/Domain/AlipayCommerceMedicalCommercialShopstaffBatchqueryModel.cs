using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalCommercialShopstaffBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalCommercialShopstaffBatchqueryModel : AopObject
    {
        /// <summary>
        /// 蚂蚁门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
