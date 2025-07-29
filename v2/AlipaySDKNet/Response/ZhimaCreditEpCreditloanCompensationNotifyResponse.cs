using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpCreditloanCompensationNotifyResponse.
    /// </summary>
    public class ZhimaCreditEpCreditloanCompensationNotifyResponse : AopResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result_content")]
        public string ResultContent { get; set; }
    }
}
