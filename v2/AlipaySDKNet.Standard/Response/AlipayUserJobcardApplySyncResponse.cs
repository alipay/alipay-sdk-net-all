using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserJobcardApplySyncResponse.
    /// </summary>
    public class AlipayUserJobcardApplySyncResponse : AopResponse
    {
        /// <summary>
        /// 职位申请ID，由职位申请系统内部生成唯一序列号
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }
    }
}
