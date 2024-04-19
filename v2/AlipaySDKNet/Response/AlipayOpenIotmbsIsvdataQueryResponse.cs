using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotmbsIsvdataQueryResponse.
    /// </summary>
    public class AlipayOpenIotmbsIsvdataQueryResponse : AopResponse
    {
        /// <summary>
        /// 根据查询类型和查询条件返回isv下的酒店id或设备sn或绑定的outfaceId（isv创建并写入的数据）
        /// </summary>
        [XmlArray("content_list")]
        [XmlArrayItem("string")]
        public List<string> ContentList { get; set; }

        /// <summary>
        /// 返回查询的数据的总条数
        /// </summary>
        [XmlElement("list_total_count")]
        public long ListTotalCount { get; set; }
    }
}
