using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobilePublicAccountlistGetResponse.
    /// </summary>
    public class AlipayMobilePublicAccountlistGetResponse : AopResponse
    {
        /// <summary>
        /// 服务窗列表
        /// </summary>
        [XmlElement("account_list")]
        public string AccountList { get; set; }

        /// <summary>
        /// 响应码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 服务窗列表总数
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }
    }
}
