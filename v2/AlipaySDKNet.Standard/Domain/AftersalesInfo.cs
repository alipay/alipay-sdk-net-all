using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AftersalesInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AftersalesInfo : AopObject
    {
        /// <summary>
        /// 售后单编号
        /// </summary>
        [XmlElement("aftersales_id")]
        public string AftersalesId { get; set; }

        /// <summary>
        /// 售后单状态
        /// </summary>
        [XmlElement("aftersales_status")]
        public string AftersalesStatus { get; set; }

        /// <summary>
        /// 卡编号
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 咨询的违约金金额，单位分，这个违约金金额是根据制卡时设置的规则以及当前卡所剩价值算出来的，无需违约金则为0
        /// </summary>
        [XmlElement("consult_damages_cash")]
        public long ConsultDamagesCash { get; set; }

        /// <summary>
        /// 咨询的退款金额，单位分，即当前卡所剩价值
        /// </summary>
        [XmlElement("consult_refund_cash")]
        public long ConsultRefundCash { get; set; }

        /// <summary>
        /// 售后发起时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 实际的违约金金额，单位分，最大不超过consultDamagesCash，商家可以调小，最小为0。售后单状态为待商家确认时，此字段没值。
        /// </summary>
        [XmlElement("damages_cash")]
        public long DamagesCash { get; set; }

        /// <summary>
        /// 用户发起售后的描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("proofs")]
        [XmlArrayItem("string")]
        public List<string> Proofs { get; set; }

        /// <summary>
        /// 售后发起原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }
    }
}
