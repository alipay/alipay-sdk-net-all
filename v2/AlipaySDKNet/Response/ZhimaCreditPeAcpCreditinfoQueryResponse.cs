using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPeAcpCreditinfoQueryResponse.
    /// </summary>
    public class ZhimaCreditPeAcpCreditinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 智能体是否获得授权
        /// </summary>
        [XmlElement("auth")]
        public string Auth { get; set; }

        /// <summary>
        /// 信用等级
        /// </summary>
        [XmlElement("credit_level_code")]
        public string CreditLevelCode { get; set; }
    }
}
