using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcMiniappPageurlQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcMiniappPageurlQueryModel : AopObject
    {
        /// <summary>
        /// 页面跳链需要业务属性
        /// </summary>
        [XmlElement("biz_data")]
        public MiniAppPageBizAttrContent BizData { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 当page_type为THIRD_MINI_APP时，需要配合page_id来确认跳转到三方小程序的具体哪个页面
        /// </summary>
        [XmlElement("page_id")]
        public string PageId { get; set; }

        /// <summary>
        /// 页面类型，传需要跳转到具体位置的页面类型，如企业码小程序列表页，或者三方小程序某个页面
        /// </summary>
        [XmlElement("page_type")]
        public string PageType { get; set; }
    }
}
