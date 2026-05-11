using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FailSnDetail Data Structure.
    /// </summary>
    [Serializable]
    public class FailSnDetail : AopObject
    {
        /// <summary>
        /// 模块失败详情code
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 模块失败详情
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }

        /// <summary>
        /// 商户路由链接
        /// </summary>
        [XmlElement("route_url")]
        public string RouteUrl { get; set; }

        /// <summary>
        /// 处理状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 线圈id
        /// </summary>
        [XmlElement("tag_id")]
        public string TagId { get; set; }

        /// <summary>
        /// 线圈sn
        /// </summary>
        [XmlElement("tag_sn")]
        public string TagSn { get; set; }
    }
}
