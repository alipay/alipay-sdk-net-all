using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppItemCateattrQueryResponse.
    /// </summary>
    public class AlipayOpenAppItemCateattrQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("cat_attr_list")]
        [XmlArrayItem("category_attribute_info_v_o")]
        public List<CategoryAttributeInfoVO> CatAttrList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("control_rule")]
        [XmlArrayItem("control_rule_v_o")]
        public List<ControlRuleVO> ControlRule { get; set; }
    }
}
