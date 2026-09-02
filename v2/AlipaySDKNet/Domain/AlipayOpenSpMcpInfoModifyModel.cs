using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpMcpInfoModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpMcpInfoModifyModel : AopObject
    {
        /// <summary>
        /// MCP能力编码code
        /// </summary>
        [XmlElement("ability_code")]
        public string AbilityCode { get; set; }

        /// <summary>
        /// 秘钥或令牌的值
        /// </summary>
        [XmlElement("api_key")]
        public string ApiKey { get; set; }

        /// <summary>
        /// 传输加密关联的加密应用。由调用方（服务商）入参指定其名下应用；推荐使用三方应用
        /// </summary>
        [XmlElement("encrypt_app_id")]
        public string EncryptAppId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("header_list")]
        [XmlArrayItem("header_param")]
        public List<HeaderParam> HeaderList { get; set; }

        /// <summary>
        /// MCP中文名
        /// </summary>
        [XmlElement("mcp_chinese_name")]
        public string McpChineseName { get; set; }

        /// <summary>
        /// MCP描述
        /// </summary>
        [XmlElement("mcp_desc")]
        public string McpDesc { get; set; }

        /// <summary>
        /// 是 支持 PNG、JPG、SVG 格式，大小 ≤ 1MB，建议 1:1，至少 128×128。使用 alipay.open.file.upload接口上传图片获取的file_id。
        /// </summary>
        [XmlElement("mcp_icon_pic")]
        public string McpIconPic { get; set; }

        /// <summary>
        /// MCP服务URL
        /// </summary>
        [XmlElement("mcp_server_url")]
        public string McpServerUrl { get; set; }

        /// <summary>
        /// 秘钥或令牌对应的参数名称
        /// </summary>
        [XmlElement("parameter_name")]
        public string ParameterName { get; set; }

        /// <summary>
        /// 请求超时时间(ms)
        /// </summary>
        [XmlElement("request_timeout")]
        public string RequestTimeout { get; set; }

        /// <summary>
        /// 响应超时时间(ms)
        /// </summary>
        [XmlElement("response_timeout")]
        public string ResponseTimeout { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("support_account_type")]
        [XmlArrayItem("string")]
        public List<string> SupportAccountType { get; set; }

        /// <summary>
        /// 支持的传输协议
        /// </summary>
        [XmlElement("support_protocols")]
        public string SupportProtocols { get; set; }
    }
}
