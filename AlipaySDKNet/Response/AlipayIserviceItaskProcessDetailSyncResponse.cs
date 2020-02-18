using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceItaskProcessDetailSyncResponse.
    /// </summary>
    public class AlipayIserviceItaskProcessDetailSyncResponse : AopResponse
    {
        /// <summary>
        /// 蚂蚁工单编号
        /// </summary>
        [XmlElement("alipay_process_id")]
        public string AlipayProcessId { get; set; }
    }
}
