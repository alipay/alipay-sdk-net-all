using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncPidUnwriteoffQueryResponse.
    /// </summary>
    public class AlipayBossFncPidUnwriteoffQueryResponse : AopResponse
    {
        /// <summary>
        /// true表示正在核销，false表示当前没有核销的单据
        /// </summary>
        [XmlElement("result_set")]
        public string ResultSet { get; set; }
    }
}
