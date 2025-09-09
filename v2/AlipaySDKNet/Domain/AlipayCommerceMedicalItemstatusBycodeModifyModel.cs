using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalItemstatusBycodeModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalItemstatusBycodeModifyModel : AopObject
    {
        /// <summary>
        /// 要操作上下架的商品, itemCode和操作类型信息
        /// </summary>
        [XmlArray("item_info_list")]
        [XmlArrayItem("item_code_status_info")]
        public List<ItemCodeStatusInfo> ItemInfoList { get; set; }

        /// <summary>
        /// app方门店编码, 用于标识定位要操作商品的指定门店, 创建门店时设置的值
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }
    }
}
