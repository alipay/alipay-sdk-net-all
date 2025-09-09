using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalSkuModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalSkuModifyModel : AopObject
    {
        /// <summary>
        /// 需要修改的sku信息列表，包括店内码，价格，货架码，重量，体积
        /// </summary>
        [XmlArray("sku_list")]
        [XmlArrayItem("sku_simple_info_param")]
        public List<SkuSimpleInfoParam> SkuList { get; set; }

        /// <summary>
        /// OMS厂商门店编码, 录入门店时填写的值, 厂商自行维护
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }
    }
}
