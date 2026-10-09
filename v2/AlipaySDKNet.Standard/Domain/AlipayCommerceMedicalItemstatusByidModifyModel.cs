using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalItemstatusByidModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalItemstatusByidModifyModel : AopObject
    {
        /// <summary>
        /// 要操作的上下架商品列表, 元素包含商品平台id和上下架状态
        /// </summary>
        [XmlArray("item_info_list")]
        [XmlArrayItem("item_id_status_info")]
        public List<ItemIdStatusInfo> ItemInfoList { get; set; }

        /// <summary>
        /// app方门店编码, 用于标识定位要操作商品的指定门店, 创建门店时设置的值
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }
    }
}
