using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiCateringPosCategoryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosCategoryQueryModel : AopObject
    {
        /// <summary>
        /// 分类ID
        /// </summary>
        [XmlElement("cate_id")]
        public string CateId { get; set; }
    }
}
