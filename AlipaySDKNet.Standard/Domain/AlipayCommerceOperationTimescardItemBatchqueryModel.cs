using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationTimescardItemBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationTimescardItemBatchqueryModel : AopObject
    {
        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 分页size
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 商品状态 已上架ONLINE / 已下架OFFLINE
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
