using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreditTradePayBusinessParams Data Structure.
    /// </summary>
    [Serializable]
    public class CreditTradePayBusinessParams : AopObject
    {
        /// <summary>
        /// 信用参数，可选
        /// </summary>
        [XmlElement("credit_biz_params")]
        public string CreditBizParams { get; set; }
    }
}
