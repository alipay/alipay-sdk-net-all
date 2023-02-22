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
        /// 参数名：content_list+使用场景：根据查询类型和查询条件返回isv下的酒店id或设备sn或绑定的outfaceId（isv创建并写入的数据）+枚举值：无
        /// </summary>
        [XmlArray("content_list")]
        [XmlArrayItem("string")]
        public List<string> ContentList { get; set; }

        /// <summary>
        /// 参数名：list_total_count+使用场景：返回查询的数据的总条数+枚举值：无
        /// </summary>
        [XmlElement("list_total_count")]
        public long ListTotalCount { get; set; }
    }
}
