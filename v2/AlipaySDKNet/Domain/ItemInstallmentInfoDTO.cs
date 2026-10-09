using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemInstallmentInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemInstallmentInfoDTO : AopObject
    {
        /// <summary>
        /// 分期商品每期金额不固定时，请填入该字段，分期时分期金额会与该字段进行比较，单位为元。
        /// </summary>
        [XmlElement("period_max_price")]
        public string PeriodMaxPrice { get; set; }

        /// <summary>
        /// 分期商品对应的总分期数
        /// </summary>
        [XmlElement("period_num")]
        public long PeriodNum { get; set; }

        /// <summary>
        /// 分期商品每期金额固定时，请填入该字段，分期时分期金额会与该字段进行比较，单位为元
        /// </summary>
        [XmlElement("period_price")]
        public string PeriodPrice { get; set; }
    }
}
