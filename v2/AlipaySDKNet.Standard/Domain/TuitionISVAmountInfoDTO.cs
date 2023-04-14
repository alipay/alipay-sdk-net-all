using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TuitionISVAmountInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TuitionISVAmountInfoDTO : AopObject
    {
        /// <summary>
        /// 费用明细
        /// </summary>
        [XmlArray("charge_details")]
        [XmlArrayItem("tuition_i_s_v_charge_detail_d_t_o")]
        public List<TuitionISVChargeDetailDTO> ChargeDetails { get; set; }

        /// <summary>
        /// 汇率（精确到小数点后8位）
        /// </summary>
        [XmlElement("exchange_rate")]
        public string ExchangeRate { get; set; }

        /// <summary>
        /// 原金额
        /// </summary>
        [XmlElement("original_amount")]
        public TuitionMoneyDTO OriginalAmount { get; set; }

        /// <summary>
        /// 目标金额
        /// </summary>
        [XmlElement("target_amount")]
        public TuitionMoneyDTO TargetAmount { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        [XmlElement("total_amount")]
        public TuitionMoneyDTO TotalAmount { get; set; }
    }
}
