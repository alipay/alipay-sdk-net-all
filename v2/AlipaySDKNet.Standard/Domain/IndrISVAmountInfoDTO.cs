using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndrISVAmountInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class IndrISVAmountInfoDTO : AopObject
    {
        /// <summary>
        /// 费用明细。（目前费用明细包含支付宝手续费、足额到账费，费用名称分别为hanlding_fee、full_value_fee）
        /// </summary>
        [XmlElement("charge_details")]
        public IndrISVChargeDetailDTO ChargeDetails { get; set; }

        /// <summary>
        /// 汇率（精确到小数点后8位）
        /// </summary>
        [XmlElement("exchange_rate")]
        public string ExchangeRate { get; set; }

        /// <summary>
        /// 原金额
        /// </summary>
        [XmlElement("original_amount")]
        public IndrMoneyDTO OriginalAmount { get; set; }

        /// <summary>
        /// 目标金额
        /// </summary>
        [XmlElement("target_amount")]
        public IndrMoneyDTO TargetAmount { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        [XmlElement("total_amount")]
        public IndrMoneyDTO TotalAmount { get; set; }
    }
}
