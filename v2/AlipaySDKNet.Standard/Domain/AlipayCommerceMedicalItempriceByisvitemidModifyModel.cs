using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalItempriceByisvitemidModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalItempriceByisvitemidModifyModel : AopObject
    {
        /// <summary>
        /// OMS厂商门店编码, 厂商自行维护
        /// </summary>
        [XmlElement("isv_store_code")]
        public string IsvStoreCode { get; set; }

        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlArray("item_price_list")]
        [XmlArrayItem("item_price_update_by_isv_item_id_param")]
        public List<ItemPriceUpdateByIsvItemIdParam> ItemPriceList { get; set; }
    }
}
