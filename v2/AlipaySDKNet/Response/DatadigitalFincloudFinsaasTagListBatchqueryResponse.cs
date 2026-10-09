using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasTagListBatchqueryResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasTagListBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 标签类目列表+不唯一
        /// </summary>
        [XmlArray("category_list")]
        [XmlArrayItem("one_category_d_t_o")]
        public List<OneCategoryDTO> CategoryList { get; set; }
    }
}
