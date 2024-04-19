using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvGoodsinfoBatchqueryResponse.
    /// </summary>
    public class AlipayMsaasMediarecogMmtcaftscvGoodsinfoBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 商品信息列表
        /// </summary>
        [XmlArray("goods_infos")]
        [XmlArrayItem("algorithm_goods_info")]
        public List<AlgorithmGoodsInfo> GoodsInfos { get; set; }
    }
}
