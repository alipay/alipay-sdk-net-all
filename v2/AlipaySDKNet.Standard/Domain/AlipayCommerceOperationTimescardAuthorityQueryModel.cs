using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationTimescardAuthorityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationTimescardAuthorityQueryModel : AopObject
    {
        /// <summary>
        /// 分页页码
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页显示数量
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 场景码，固定值
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
