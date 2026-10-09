using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingImageDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingImageDeleteModel : AopObject
    {
        /// <summary>
        /// 需要操作删除的图片索引id列表。
        /// </summary>
        [XmlArray("image_index_id_list")]
        [XmlArrayItem("string")]
        public List<string> ImageIndexIdList { get; set; }
    }
}
