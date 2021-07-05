using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniResourceDataQueryResponse.
    /// </summary>
    public class AlipayOpenMiniResourceDataQueryResponse : AopResponse
    {
        /// <summary>
        /// 流量位数据列表
        /// </summary>
        [XmlArray("resource_data_list")]
        [XmlArrayItem("resource_data_v_o")]
        public List<ResourceDataVO> ResourceDataList { get; set; }
    }
}
