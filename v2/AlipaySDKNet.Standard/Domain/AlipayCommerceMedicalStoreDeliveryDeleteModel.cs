using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalStoreDeliveryDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalStoreDeliveryDeleteModel : AopObject
    {
        /// <summary>
        /// app方配送范围编码，商户手动输入
        /// </summary>
        [XmlElement("app_delivery_code")]
        public string AppDeliveryCode { get; set; }

        /// <summary>
        /// 门店编码，商家自定义，录入门店时必填
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }
    }
}
