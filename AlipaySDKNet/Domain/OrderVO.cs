using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderVO Data Structure.
    /// </summary>
    [Serializable]
    public class OrderVO : AopObject
    {
        /// <summary>
        /// 订单金额-单位为分
        /// </summary>
        [XmlElement("apply_amount")]
        public string ApplyAmount { get; set; }

        /// <summary>
        /// 订单申请时间
        /// </summary>
        [XmlElement("apply_date")]
        public string ApplyDate { get; set; }

        /// <summary>
        /// 交易来源传递的交易编号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("ccy")]
        public string Ccy { get; set; }

        /// <summary>
        /// 订单生效时间
        /// </summary>
        [XmlElement("effect_date")]
        public string EffectDate { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 订单到期时间
        /// </summary>
        [XmlElement("repay_date")]
        public string RepayDate { get; set; }

        /// <summary>
        /// CREATE(投标中)/CANCEL(未中标)/VALID(中标)/PAYING(支付中)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
