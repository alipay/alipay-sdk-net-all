using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InterTradeBillConsultOpenApiResult Data Structure.
    /// </summary>
    [Serializable]
    public class InterTradeBillConsultOpenApiResult : AopObject
    {
        /// <summary>
        /// 是否创建对手方计价明细
        /// </summary>
        [XmlElement("create_opposite_bill")]
        public bool CreateOppositeBill { get; set; }

        /// <summary>
        /// 是否为关联交易
        /// </summary>
        [XmlElement("inter_trade")]
        public bool InterTrade { get; set; }

        /// <summary>
        /// 交易对手方关联方短码
        /// </summary>
        [XmlElement("opposite_ou_code")]
        public string OppositeOuCode { get; set; }

        /// <summary>
        /// 关联交易类型，等价于对手方归属组织。 ALIBABA     阿里巴巴并表公司 ALIBABA-JV  阿里巴巴合营企业 MY          蚂蚁并表公司 MY-invest   蚂蚁被投企业 MY-JV       蚂蚁合营企业 MY-AFS      蚂蚁联营企业 Other       蚂蚁股东 NOTRELATED   非关联方
        /// </summary>
        [XmlElement("relation_type")]
        public string RelationType { get; set; }

        /// <summary>
        /// 交易本方关联方短码
        /// </summary>
        [XmlElement("self_ou_code")]
        public string SelfOuCode { get; set; }
    }
}
