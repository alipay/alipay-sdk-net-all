using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniWidgetGoodsQueryResponse.
    /// </summary>
    public class AlipayOpenMiniWidgetGoodsQueryResponse : AopResponse
    {
        /// <summary>
        /// 商品信息列表
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("goods_query_response")]
        public List<GoodsQueryResponse> DataList { get; set; }

        /// <summary>
        /// 查询第几页
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 查询页面数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询结果总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
