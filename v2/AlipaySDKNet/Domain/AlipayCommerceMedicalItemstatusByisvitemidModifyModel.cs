using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalItemstatusByisvitemidModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalItemstatusByisvitemidModifyModel : AopObject
    {
        /// <summary>
        /// OMS厂商门店编码, 厂商自行维护
        /// </summary>
        [XmlElement("isv_store_code")]
        public string IsvStoreCode { get; set; }

        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlArray("item_status_list")]
        [XmlArrayItem("item_status_update_by_isv_item_id_param")]
        public List<ItemStatusUpdateByIsvItemIdParam> ItemStatusList { get; set; }
    }
}
