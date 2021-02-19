using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankFinanceYulibaoAccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankFinanceYulibaoAccountQueryModel : AopObject
    {
        /// <summary>
        /// 基金代码。余利宝场景固定为 001529。
        /// </summary>
        [XmlElement("fund_code")]
        public string FundCode { get; set; }
    }
}
