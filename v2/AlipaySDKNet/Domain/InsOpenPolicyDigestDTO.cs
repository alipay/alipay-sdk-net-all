using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsOpenPolicyDigestDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsOpenPolicyDigestDTO : AopObject
    {
        /// <summary>
        /// 保险公司id
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 保司保单号
        /// </summary>
        [XmlElement("inst_policy_no")]
        public string InstPolicyNo { get; set; }

        /// <summary>
        /// 保单关联的责任摘要信息
        /// </summary>
        [XmlArray("liabilities")]
        [XmlArrayItem("ins_open_policy_liability_digest_d_t_o")]
        public List<InsOpenPolicyLiabilityDigestDTO> Liabilities { get; set; }

        /// <summary>
        /// 保单生效时间
        /// </summary>
        [XmlElement("policy_effect_time")]
        public string PolicyEffectTime { get; set; }

        /// <summary>
        /// 保单结束时间
        /// </summary>
        [XmlElement("policy_end_time")]
        public string PolicyEndTime { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 保单状态：INIT (初始化/未出单)，ISSUED(已出单)，SURRENDERRED(已退保)，CLOSED(关单已解约 )，SUSPENSION(已中止)
        /// </summary>
        [XmlElement("policy_status")]
        public string PolicyStatus { get; set; }

        /// <summary>
        /// 预下单id
        /// </summary>
        [XmlElement("pre_order_id")]
        public string PreOrderId { get; set; }

        /// <summary>
        /// 保费，单位分
        /// </summary>
        [XmlElement("premium")]
        public long Premium { get; set; }

        /// <summary>
        /// 产品编码，标识某一类产品 :YFX (运费险),JYBZ(交易保障险),SHX(售后险)
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 自行寄回保额，单位分，仅在运费险产品返回
        /// </summary>
        [XmlElement("self_delivery_sum_insured")]
        public long SelfDeliverySumInsured { get; set; }

        /// <summary>
        /// 保额，单位分
        /// </summary>
        [XmlElement("sum_insured")]
        public long SumInsured { get; set; }
    }
}
