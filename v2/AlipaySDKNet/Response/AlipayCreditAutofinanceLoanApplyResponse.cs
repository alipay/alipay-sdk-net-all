using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCreditAutofinanceLoanApplyResponse.
    /// </summary>
    public class AlipayCreditAutofinanceLoanApplyResponse : AopResponse
    {
        /// <summary>
        /// 汽车金融内部订单号
        /// </summary>
        [XmlElement("applyno")]
        public string Applyno { get; set; }

        /// <summary>
        /// 是否需要引导认证
        /// </summary>
        [XmlElement("needauth")]
        public bool Needauth { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("outorderno")]
        public string Outorderno { get; set; }
    }
}
