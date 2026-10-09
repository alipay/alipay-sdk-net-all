using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TuitionISVPoboPaymentResult Data Structure.
    /// </summary>
    [Serializable]
    public class TuitionISVPoboPaymentResult : AopObject
    {
        /// <summary>
        /// 交易号，刷卡后可能会返回
        /// </summary>
        [XmlElement("payment_id")]
        public string PaymentId { get; set; }

        /// <summary>
        /// 证明材料，isv刷卡后返回
        /// </summary>
        [XmlArray("proof_list")]
        [XmlArrayItem("tuition_i_s_v_pobo_image_d_t_o")]
        public List<TuitionISVPoboImageDTO> ProofList { get; set; }

        /// <summary>
        /// FAIL和CANCEL时必填，表示失败或者取消的原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// vcc交易状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
