using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenBrandInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenBrandInfoQueryModel : AopObject
    {
        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 从第1页开始
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页数1-10页
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
