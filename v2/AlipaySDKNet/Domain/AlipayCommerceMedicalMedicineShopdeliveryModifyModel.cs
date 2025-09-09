using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMedicineShopdeliveryModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMedicineShopdeliveryModifyModel : AopObject
    {
        /// <summary>
        /// 门店配送配置信息
        /// </summary>
        [XmlArray("delivery_info")]
        [XmlArrayItem("medical_shop_delivery_info")]
        public List<MedicalShopDeliveryInfo> DeliveryInfo { get; set; }

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
