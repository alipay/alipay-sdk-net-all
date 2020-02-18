using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvGoodsinfoBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogMmtcaftscvGoodsinfoBatchqueryModel : AopObject
    {
        /// <summary>
        /// 算法id列表
        /// </summary>
        [XmlArray("algorithm_ids")]
        [XmlArrayItem("string")]
        public List<string> AlgorithmIds { get; set; }
    }
}
