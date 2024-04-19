using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerJobworthQuickhireSubmitResponse.
    /// </summary>
    public class ZhimaCustomerJobworthQuickhireSubmitResponse : AopResponse
    {
        /// <summary>
        /// 投递同步是否成功，true = 成功，false = 失败
        /// </summary>
        [XmlElement("deliver_result")]
        public bool DeliverResult { get; set; }
    }
}
