using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCommonRelationSetResponse.
    /// </summary>
    public class AlipayCommerceCommonRelationSetResponse : AopResponse
    {
        /// <summary>
        /// 解绑/绑定操作结果
        /// </summary>
        [XmlElement("operation_result")]
        public bool OperationResult { get; set; }

        /// <summary>
        /// 绑定/解绑时间
        /// </summary>
        [XmlElement("operation_time")]
        public string OperationTime { get; set; }
    }
}
