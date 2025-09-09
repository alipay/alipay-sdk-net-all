using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalStoreBusinessOnlineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalStoreBusinessOnlineModel : AopObject
    {
        /// <summary>
        /// APP方门店编码
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }
    }
}
