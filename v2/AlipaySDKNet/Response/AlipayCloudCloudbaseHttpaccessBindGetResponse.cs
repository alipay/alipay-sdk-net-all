using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseHttpaccessBindGetResponse.
    /// </summary>
    public class AlipayCloudCloudbaseHttpaccessBindGetResponse : AopResponse
    {
        /// <summary>
        /// 路由绑定ID
        /// </summary>
        [XmlElement("bind_id")]
        public string BindId { get; set; }

        /// <summary>
        /// 域名
        /// </summary>
        [XmlElement("domain_name")]
        public string DomainName { get; set; }

        /// <summary>
        /// 函数名称
        /// </summary>
        [XmlElement("function_name")]
        public string FunctionName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 是否自定义域名
        /// </summary>
        [XmlElement("is_custom")]
        public bool IsCustom { get; set; }

        /// <summary>
        /// 是否需要签名
        /// </summary>
        [XmlElement("need_sign")]
        public bool NeedSign { get; set; }

        /// <summary>
        /// 触发路径
        /// </summary>
        [XmlElement("path")]
        public string Path { get; set; }
    }
}
