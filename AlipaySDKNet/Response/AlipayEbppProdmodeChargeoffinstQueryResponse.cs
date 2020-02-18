using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppProdmodeChargeoffinstQueryResponse.
    /// </summary>
    public class AlipayEbppProdmodeChargeoffinstQueryResponse : AopResponse
    {
        /// <summary>
        /// 销账机构下拉列表
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("biz_list_data_info")]
        public List<BizListDataInfo> DataList { get; set; }
    }
}
