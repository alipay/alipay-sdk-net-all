using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayIotNfcoperateModifyResponse.
    /// </summary>
    public class AlipayPayIotNfcoperateModifyResponse : AopResponse
    {
        /// <summary>
        /// 操作成功的计划id
        /// </summary>
        [XmlElement("operate_plan")]
        public long OperatePlan { get; set; }
    }
}
