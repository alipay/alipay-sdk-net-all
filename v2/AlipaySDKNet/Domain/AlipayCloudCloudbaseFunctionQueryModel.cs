using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseFunctionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseFunctionQueryModel : AopObject
    {
        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }

        /// <summary>
        /// 是否逆序
        /// </summary>
        [XmlElement("desc")]
        public bool Desc { get; set; }

        /// <summary>
        /// 云函数名称（精准匹配）
        /// </summary>
        [XmlElement("function_name")]
        public string FunctionName { get; set; }

        /// <summary>
        /// 云函数名称（模糊匹配）
        /// </summary>
        [XmlElement("function_name_like")]
        public string FunctionNameLike { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 每页展示数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 状态  - PUB_UNDONE  - PUB_DOING  - PUB_SUCCESS  - PUB_FAILED
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
