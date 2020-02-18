using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserMaterialBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceIotAdvertiserMaterialBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 物料列表
        /// </summary>
        [XmlArray("material_infos")]
        [XmlArrayItem("ad_material_info")]
        public List<AdMaterialInfo> MaterialInfos { get; set; }

        /// <summary>
        /// 总大小
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
