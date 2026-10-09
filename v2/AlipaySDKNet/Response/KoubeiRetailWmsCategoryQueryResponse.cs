using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiRetailWmsCategoryQueryResponse.
    /// </summary>
    public class KoubeiRetailWmsCategoryQueryResponse : AopResponse
    {
        /// <summary>
        /// 类目信息
        /// </summary>
        [XmlElement("category")]
        public CategoryVO Category { get; set; }

        /// <summary>
        /// 子类目信息
        /// </summary>
        [XmlArray("sub_categories")]
        [XmlArrayItem("category_v_o")]
        public List<CategoryVO> SubCategories { get; set; }
    }
}
