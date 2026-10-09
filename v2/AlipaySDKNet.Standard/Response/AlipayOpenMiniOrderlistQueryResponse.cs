using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniOrderlistQueryResponse.
    /// </summary>
    public class AlipayOpenMiniOrderlistQueryResponse : AopResponse
    {
        /// <summary>
        /// 订单列表
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("simple_mini_order_info_v_o")]
        public List<SimpleMiniOrderInfoVO> DataList { get; set; }

        /// <summary>
        /// 分页页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
