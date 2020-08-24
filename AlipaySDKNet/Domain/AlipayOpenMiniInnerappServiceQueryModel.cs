using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerappServiceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerappServiceQueryModel : AopObject
    {
        /// <summary>
        /// 业务来源，新接入方需要向支付宝申请专用来源，否则不予接入。https://yuque.antfin-inc.com/tinyapp-all/qddncu/bidushixiang
        /// </summary>
        [XmlElement("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 小程序应用子类型
        /// </summary>
        [XmlElement("app_sub_type")]
        public string AppSubType { get; set; }

        /// <summary>
        /// 是否需要展示offline状态插件，不传默认为false（不展示）
        /// </summary>
        [XmlElement("include_offline")]
        public bool IncludeOffline { get; set; }

        /// <summary>
        /// 关键词
        /// </summary>
        [XmlElement("keyword")]
        public string Keyword { get; set; }

        /// <summary>
        /// 插件id或模板id
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 页码，默认第一页
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 分页数，默认每页10个
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 是否在服务市场透出，SHOW展示、HIDE隐藏
        /// </summary>
        [XmlElement("show_type")]
        public string ShowType { get; set; }
    }
}
