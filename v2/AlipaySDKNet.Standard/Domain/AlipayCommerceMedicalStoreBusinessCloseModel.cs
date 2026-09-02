using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalStoreBusinessCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalStoreBusinessCloseModel : AopObject
    {
        /// <summary>
        /// 门店编码
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }
    }
}
