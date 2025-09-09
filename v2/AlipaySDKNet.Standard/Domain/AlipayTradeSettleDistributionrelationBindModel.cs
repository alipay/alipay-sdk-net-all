using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSettleDistributionrelationBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSettleDistributionrelationBindModel : AopObject
    {
        /// <summary>
        /// 外部请求号，用于接口幂等
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户绑定关系列表
        /// </summary>
        [XmlArray("receiver_list")]
        [XmlArrayItem("merchant_relation_entity")]
        public List<MerchantRelationEntity> ReceiverList { get; set; }

        /// <summary>
        /// 关系绑定场景，目前只支持consignment
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
