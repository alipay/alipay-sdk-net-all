using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalItemByidDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalItemByidDeleteModel : AopObject
    {
        /// <summary>
        /// 支付宝内部商品编码ID
        /// </summary>
        [XmlArray("item_id_list")]
        [XmlArrayItem("string")]
        public List<string> ItemIdList { get; set; }

        /// <summary>
        /// OMS厂商门店编码, 厂商自行维护
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }
    }
}
