using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpFreedepositInitializeResponse.
    /// </summary>
    public class ZhimaCreditEpFreedepositInitializeResponse : AopResponse
    {
        /// <summary>
        /// 免押额度业务流水号，每次业务唯一。
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
