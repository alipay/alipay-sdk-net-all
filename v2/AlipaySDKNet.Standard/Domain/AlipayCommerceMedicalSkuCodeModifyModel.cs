using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalSkuCodeModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalSkuCodeModifyModel : AopObject
    {
        /// <summary>
        /// 商家需要修改的旧sku店内码&新sku店内码组合列表
        /// </summary>
        [XmlArray("sku_code_mapping_list")]
        [XmlArrayItem("sku_code_mapping_param")]
        public List<SkuCodeMappingParam> SkuCodeMappingList { get; set; }

        /// <summary>
        /// app方门店编码, 用于标识定位要操作商品的指定门店, 创建门店时设置的值
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }
    }
}
