using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalStoreDeliveryspecialSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalStoreDeliveryspecialSaveModel : AopObject
    {
        /// <summary>
        /// 配送范围详情
        /// </summary>
        [XmlElement("delivery_area")]
        public Delivery DeliveryArea { get; set; }

        /// <summary>
        /// 配送范围生效时间
        /// </summary>
        [XmlElement("delivery_time")]
        public EffectivePeriodDTO DeliveryTime { get; set; }

        /// <summary>
        /// 门店编码，商家自定义，录入门店时必填。
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }
    }
}
