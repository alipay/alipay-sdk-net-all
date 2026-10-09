using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalItemCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalItemCreateModel : AopObject
    {
        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("item_create_info_param")]
        public List<ItemCreateInfoParam> ItemList { get; set; }

        /// <summary>
        /// OMS厂商门店编码, 录入门店时填写的值, 厂商自行维护
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }
    }
}
