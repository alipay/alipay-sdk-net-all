using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalItemstatusByskucodeModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalItemstatusByskucodeModifyModel : AopObject
    {
        /// <summary>
        /// 要操作上下架的商品, skuCode和操作类型信息
        /// </summary>
        [XmlArray("sku_info_list")]
        [XmlArrayItem("sku_code_status_param")]
        public List<SkuCodeStatusParam> SkuInfoList { get; set; }

        /// <summary>
        /// OMS厂商门店编码，用于标识定位要操作商品的指定门店, 创建门店时设置的值
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }
    }
}
