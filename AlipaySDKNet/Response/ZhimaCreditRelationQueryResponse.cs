using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditRelationQueryResponse.
    /// </summary>
    public class ZhimaCreditRelationQueryResponse : AopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 对关系的具体描述，只有存在关系时才能输出
        /// </summary>
        [XmlElement("relation_info")]
        public RelationInfo RelationInfo { get; set; }

        /// <summary>
        /// 关系强度，具体关系强度code见产品文档
        /// </summary>
        [XmlElement("relation_rank")]
        public string RelationRank { get; set; }

        /// <summary>
        /// 0~100整数，分数越高与输入关系越匹配度越高，如果入参无relation，则该值为0
        /// </summary>
        [XmlElement("relation_score")]
        public long RelationScore { get; set; }
    }
}
