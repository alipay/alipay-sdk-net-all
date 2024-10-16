using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantSolcreditserviceprodScenecategoryQueryResponse.
    /// </summary>
    public class AlipayMerchantSolcreditserviceprodScenecategoryQueryResponse : AopResponse
    {
        /// <summary>
        /// 场景类目信息列表
        /// </summary>
        [XmlArray("scene_category_list")]
        [XmlArrayItem("scene_category_d_t_o")]
        public List<SceneCategoryDTO> SceneCategoryList { get; set; }
    }
}
