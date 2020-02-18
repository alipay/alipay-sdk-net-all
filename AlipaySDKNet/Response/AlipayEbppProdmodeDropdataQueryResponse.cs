using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppProdmodeDropdataQueryResponse.
    /// </summary>
    public class AlipayEbppProdmodeDropdataQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回业务类型、子业务类型、产品模式及销账模式下拉列表
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("biz_list_data_info")]
        public List<BizListDataInfo> DataList { get; set; }
    }
}
