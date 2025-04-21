using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalStorePharmacistQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalStorePharmacistQueryResponse : AopResponse
    {
        /// <summary>
        /// 药师信息列表
        /// </summary>
        [XmlArray("pharmacists")]
        [XmlArrayItem("pharmacist_v_o")]
        public List<PharmacistVO> Pharmacists { get; set; }

        /// <summary>
        /// 门店药师总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
