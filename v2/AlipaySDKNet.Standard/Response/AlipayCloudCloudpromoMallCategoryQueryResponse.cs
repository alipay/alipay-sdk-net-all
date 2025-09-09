using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoMallCategoryQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoMallCategoryQueryResponse : AopResponse
    {
        /// <summary>
        /// 类目信息
        /// </summary>
        [XmlArray("categories")]
        [XmlArrayItem("lm_category_v_o")]
        public List<LmCategoryVO> Categories { get; set; }
    }
}
