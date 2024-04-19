using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniCategoryRequireQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniCategoryRequireQueryModel : AopObject
    {
        /// <summary>
        /// 类目列表，不超过五个
        /// </summary>
        [XmlArray("category_code_list")]
        [XmlArrayItem("string")]
        public List<string> CategoryCodeList { get; set; }
    }
}
