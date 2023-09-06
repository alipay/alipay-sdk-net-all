using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncInputinvoiceBeforedistributeModifyResponse.
    /// </summary>
    public class AlipayBossFncInputinvoiceBeforedistributeModifyResponse : AopResponse
    {
        /// <summary>
        /// 批量修改结果
        /// </summary>
        [XmlElement("result_set")]
        public BatchModifyResponse ResultSet { get; set; }
    }
}
