using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingToolXuanyitestCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingToolXuanyitestCreateModel : AopObject
    {
        /// <summary>
        /// 这是一个复杂类型测试描述
        /// </summary>
        [XmlArray("test_12")]
        [XmlArrayItem("transfer_result_info")]
        public List<TransferResultInfo> Test12 { get; set; }
    }
}
