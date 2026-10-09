using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenOperationIspTestUseResponse.
    /// </summary>
    public class AlipayOpenOperationIspTestUseResponse : AopResponse
    {
        /// <summary>
        /// 应用信息列表
        /// </summary>
        [XmlArray("app_info")]
        [XmlArrayItem("app_test_info")]
        public List<AppTestInfo> AppInfo { get; set; }

        /// <summary>
        /// 测试参数
        /// </summary>
        [XmlElement("output")]
        public long Output { get; set; }
    }
}
