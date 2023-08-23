using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppJfSignApplyResponse.
    /// </summary>
    public class AlipayEbppJfSignApplyResponse : AopResponse
    {
        /// <summary>
        /// 外部业务号,和接口传入的外部业务号保持一致
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 异步签约流程的唯一标识
        /// </summary>
        [XmlElement("process_id")]
        public string ProcessId { get; set; }
    }
}
