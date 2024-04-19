using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingToolXuanyitestCreateResponse.
    /// </summary>
    public class AlipayMarketingToolXuanyitestCreateResponse : AopResponse
    {
        /// <summary>
        /// 这是一个复杂类型测试描述
        /// </summary>
        [XmlArray("test_12")]
        [XmlArrayItem("transfer_result_info")]
        public List<TransferResultInfo> Test12 { get; set; }
    }
}
