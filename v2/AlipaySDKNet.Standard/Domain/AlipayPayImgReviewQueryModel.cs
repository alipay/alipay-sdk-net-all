using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayImgReviewQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayImgReviewQueryModel : AopObject
    {
        /// <summary>
        /// 查询依据的文件id
        /// </summary>
        [XmlElement("material_id")]
        public string MaterialId { get; set; }
    }
}
