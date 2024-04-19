using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInstserviceSignresultBatchqueryResponse.
    /// </summary>
    public class AlipayEbppInstserviceSignresultBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// json格式用户签约信息；格式：{"字段名":"字段值"}
        /// </summary>
        [XmlElement("list")]
        public string List { get; set; }
    }
}
