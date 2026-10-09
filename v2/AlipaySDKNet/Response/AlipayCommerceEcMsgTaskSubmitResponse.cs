using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcMsgTaskSubmitResponse.
    /// </summary>
    public class AlipayCommerceEcMsgTaskSubmitResponse : AopResponse
    {
        /// <summary>
        /// 企业通知任务idl列表
        /// </summary>
        [XmlArray("task_id_list")]
        [XmlArrayItem("string")]
        public List<string> TaskIdList { get; set; }
    }
}
