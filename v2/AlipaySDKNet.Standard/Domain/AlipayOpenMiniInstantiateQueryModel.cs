using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniInstantiateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInstantiateQueryModel : AopObject
    {
        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序名称
        /// </summary>
        [XmlElement("mini_app_name")]
        public string MiniAppName { get; set; }

        /// <summary>
        /// 分页页数
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 是否查询详细信息
        /// </summary>
        [XmlElement("query_full")]
        public string QueryFull { get; set; }

        /// <summary>
        /// 小程序模板应用id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
