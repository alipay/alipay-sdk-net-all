using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalItemcodeBycodeModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalItemcodeBycodeModifyModel : AopObject
    {
        /// <summary>
        /// 批量修改药品编码信息
        /// </summary>
        [XmlArray("item_code_data")]
        [XmlArrayItem("item_code_update_by_code_v_o")]
        public List<ItemCodeUpdateByCodeVO> ItemCodeData { get; set; }

        /// <summary>
        /// app方门店编码, 用于标识定位要操作商品的指定门店, 创建门店时设置的值
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }
    }
}
