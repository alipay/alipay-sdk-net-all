using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogMmportalGoverngoodsresultSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogMmportalGoverngoodsresultSyncModel : AopObject
    {
        /// <summary>
        /// 算法ID
        /// </summary>
        [XmlElement("algorithm_id")]
        public string AlgorithmId { get; set; }

        /// <summary>
        /// 检查信息，checkSuccess为false时有数据，代表哪个地方需要治理以及治理结果
        /// </summary>
        [XmlArray("check_message")]
        [XmlArrayItem("govern_goods_check_message")]
        public List<GovernGoodsCheckMessage> CheckMessage { get; set; }

        /// <summary>
        /// 检查是否通过
        /// </summary>
        [XmlElement("check_success")]
        public bool CheckSuccess { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("req_id")]
        public string ReqId { get; set; }
    }
}
