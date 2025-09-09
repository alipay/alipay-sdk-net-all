using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalStoreDetailGetResponse.
    /// </summary>
    public class AlipayCommerceMedicalStoreDetailGetResponse : AopResponse
    {
        /// <summary>
        /// 门店详情列表
        /// </summary>
        [XmlArray("records")]
        [XmlArrayItem("store_info_v_o")]
        public List<StoreInfoVO> Records { get; set; }
    }
}
