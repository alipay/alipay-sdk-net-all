using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppLocalitemAllcategoryQueryResponse.
    /// </summary>
    public class AlipayOpenAppLocalitemAllcategoryQueryResponse : AopResponse
    {
        /// <summary>
        /// 类目信息
        /// </summary>
        [XmlArray("cats")]
        [XmlArrayItem("local_category_and_parent_v_o")]
        public List<LocalCategoryAndParentVO> Cats { get; set; }
    }
}
