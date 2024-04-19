using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandFrontcategorySecurityQueryResponse.
    /// </summary>
    public class AntMerchantExpandFrontcategorySecurityQueryResponse : AopResponse
    {
        /// <summary>
        /// 前台类目列表
        /// </summary>
        [XmlArray("front_category_list")]
        [XmlArrayItem("front_category_info")]
        public List<FrontCategoryInfo> FrontCategoryList { get; set; }
    }
}
