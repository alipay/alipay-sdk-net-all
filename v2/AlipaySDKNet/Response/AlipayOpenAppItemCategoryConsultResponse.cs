using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppItemCategoryConsultResponse.
    /// </summary>
    public class AlipayOpenAppItemCategoryConsultResponse : AopResponse
    {
        /// <summary>
        /// 类目层级
        /// </summary>
        [XmlElement("cat_level")]
        public long CatLevel { get; set; }

        /// <summary>
        /// 类目不可用错误码
        /// </summary>
        [XmlElement("category_error_code")]
        public string CategoryErrorCode { get; set; }

        /// <summary>
        /// 类目不可用原因。例如：无权限；无行业白名单邀约；资质未开通；资质已开通；资质审核中；资质审核驳回；小程序的类目经营范围内没有这些商品类目；未查询到类目。
        /// </summary>
        [XmlElement("category_error_desc")]
        public string CategoryErrorDesc { get; set; }

        /// <summary>
        /// 商品类目ID
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 商品类目名称
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 类目状态。true：类目可用；false：类目不可用
        /// </summary>
        [XmlElement("status")]
        public bool Status { get; set; }
    }
}
