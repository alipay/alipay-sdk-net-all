using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppItemAllcategoryQueryResponse.
    /// </summary>
    public class AlipayOpenAppItemAllcategoryQueryResponse : AopResponse
    {
        /// <summary>
        /// 类目信息
        /// </summary>
        [XmlArray("cats")]
        [XmlArrayItem("category_and_parent_v_o")]
        public List<CategoryAndParentVO> Cats { get; set; }
    }
}
