using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLifeserviceCategorySignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLifeserviceCategorySignModel : AopObject
    {
        /// <summary>
        /// 类目编码
        /// </summary>
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("qualification_info")]
        [XmlArrayItem("axf_item_category_qualification_req")]
        public List<AxfItemCategoryQualificationReq> QualificationInfo { get; set; }
    }
}
