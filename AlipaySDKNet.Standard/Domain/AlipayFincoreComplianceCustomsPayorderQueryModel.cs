using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreComplianceCustomsPayorderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreComplianceCustomsPayorderQueryModel : AopObject
    {
        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// trade_no+唯一+海关推支付单+无+从淘宝支付交易里获取+内部菜鸟使用
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
