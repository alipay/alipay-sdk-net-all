using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSettleDistributionrelationUnbindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSettleDistributionrelationUnbindModel : AopObject
    {
        /// <summary>
        /// 外部请求号，幂等字段
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 需要解绑的商户关系列表
        /// </summary>
        [XmlArray("receiver_list")]
        [XmlArrayItem("merchant_relation_entity")]
        public List<MerchantRelationEntity> ReceiverList { get; set; }

        /// <summary>
        /// 场景，目前只支持consignment
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
