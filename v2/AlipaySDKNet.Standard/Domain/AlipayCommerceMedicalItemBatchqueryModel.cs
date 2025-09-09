using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalItemBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalItemBatchqueryModel : AopObject
    {
        /// <summary>
        /// OMS厂商商品编码列表
        /// </summary>
        [XmlArray("item_code_list")]
        [XmlArrayItem("string")]
        public List<string> ItemCodeList { get; set; }

        /// <summary>
        /// OMS厂商门店编码, 录入门店时填写的值, 厂商自行维护
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }
    }
}
