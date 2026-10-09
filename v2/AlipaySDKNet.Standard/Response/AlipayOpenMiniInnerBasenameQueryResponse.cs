using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerBasenameQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerBasenameQueryResponse : AopResponse
    {
        /// <summary>
        /// 该接口是提供给雨燕 只支持内部小程序调用的 查询app_name的接口
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }
    }
}
