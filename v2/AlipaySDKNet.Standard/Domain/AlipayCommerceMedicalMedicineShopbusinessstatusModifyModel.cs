using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMedicineShopbusinessstatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMedicineShopbusinessstatusModifyModel : AopObject
    {
        /// <summary>
        /// 门店营业状态
        /// </summary>
        [XmlElement("business_status")]
        public string BusinessStatus { get; set; }

        /// <summary>
        /// shop_id和out_store_id都传时以shop_id为准
        /// </summary>
        [XmlElement("out_store_id")]
        public string OutStoreId { get; set; }

        /// <summary>
        /// shop_id和out_store_id都传时以shop_id为准
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
