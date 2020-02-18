using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiRetailWmsGoodsQueryResponse.
    /// </summary>
    public class KoubeiRetailWmsGoodsQueryResponse : AopResponse
    {
        /// <summary>
        /// 货品信息
        /// </summary>
        [XmlArray("goods")]
        [XmlArrayItem("goods_v_o")]
        public List<GoodsVO> Goods { get; set; }

        /// <summary>
        /// 记录总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
