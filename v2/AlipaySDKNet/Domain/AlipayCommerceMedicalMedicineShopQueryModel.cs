using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMedicineShopQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMedicineShopQueryModel : AopObject
    {
        /// <summary>
        /// 外部门店Id
        /// </summary>
        [XmlElement("out_store_id")]
        public string OutStoreId { get; set; }

        /// <summary>
        /// 支付宝门店Id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
