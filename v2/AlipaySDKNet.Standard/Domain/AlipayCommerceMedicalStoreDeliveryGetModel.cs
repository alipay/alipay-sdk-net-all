using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalStoreDeliveryGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalStoreDeliveryGetModel : AopObject
    {
        /// <summary>
        /// 查询配送范围的门店的门店编码
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }
    }
}
