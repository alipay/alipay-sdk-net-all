using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiFqqrcodeHbfqCreateResponse.
    /// </summary>
    public class AlipayPcreditHuabeiFqqrcodeHbfqCreateResponse : AopResponse
    {
        /// <summary>
        /// 本次物料申领是否成功,成功为true,失败为false
        /// </summary>
        [XmlElement("apply")]
        public bool Apply { get; set; }

        /// <summary>
        /// 码申请流程id,后续可用来查询物流信息.如果申请失败的话,本字段为空.
        /// </summary>
        [XmlElement("process_id")]
        public string ProcessId { get; set; }
    }
}
