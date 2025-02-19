using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalSkuBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalSkuBatchqueryModel : AopObject
    {
        /// <summary>
        /// 商家自定义店内码/货号列表，店内码门店内唯一
        /// </summary>
        [XmlArray("sku_code_list")]
        [XmlArrayItem("string")]
        public List<string> SkuCodeList { get; set; }

        /// <summary>
        /// OMS厂商门店编码, 录入门店时填写的值, 厂商自行维护
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }
    }
}
