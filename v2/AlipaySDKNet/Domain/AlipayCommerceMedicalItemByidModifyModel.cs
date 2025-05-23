using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalItemByidModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalItemByidModifyModel : AopObject
    {
        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("item_update_by_id_param")]
        public List<ItemUpdateByIdParam> ItemList { get; set; }

        /// <summary>
        /// OMS厂商门店编码, 厂商自行维护
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }
    }
}
