using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalItemstockByisvitemidModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalItemstockByisvitemidModifyModel : AopObject
    {
        /// <summary>
        /// 清空库存商品id集合
        /// </summary>
        [XmlArray("clear_isv_item_id_list")]
        [XmlArrayItem("string")]
        public List<string> ClearIsvItemIdList { get; set; }

        /// <summary>
        /// OMS厂商门店编码, 录入门店时填写的值, 厂商自行维护
        /// </summary>
        [XmlElement("isv_store_code")]
        public string IsvStoreCode { get; set; }

        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlArray("item_stock_list")]
        [XmlArrayItem("item_stock_update_by_isv_item_id_param")]
        public List<ItemStockUpdateByIsvItemIdParam> ItemStockList { get; set; }
    }
}
