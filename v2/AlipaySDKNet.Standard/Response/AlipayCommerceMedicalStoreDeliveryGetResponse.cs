using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalStoreDeliveryGetResponse.
    /// </summary>
    public class AlipayCommerceMedicalStoreDeliveryGetResponse : AopResponse
    {
        /// <summary>
        /// 配送范围列表
        /// </summary>
        [XmlArray("delivery_list")]
        [XmlArrayItem("delivery_v_o")]
        public List<DeliveryVO> DeliveryList { get; set; }

        /// <summary>
        /// 查询门店的门店编码
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }
    }
}
