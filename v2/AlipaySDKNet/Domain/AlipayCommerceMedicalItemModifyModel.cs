using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalItemModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalItemModifyModel : AopObject
    {
        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("item_update_info_param")]
        public List<ItemUpdateInfoParam> ItemList { get; set; }

        /// <summary>
        /// OMS厂商门店编码, 厂商自行维护
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }
    }
}
