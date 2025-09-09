using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalStoreDetailGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalStoreDetailGetModel : AopObject
    {
        /// <summary>
        /// 支持传多个门店批量查询，一次调用可上传100个门店id，可通过接口alipay.commerce.medical.store.codelist.get获取商家入驻成功的所有门店编码
        /// </summary>
        [XmlArray("store_codes")]
        [XmlArrayItem("string")]
        public List<string> StoreCodes { get; set; }
    }
}
