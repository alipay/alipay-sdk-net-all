using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CategoryQualificationInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CategoryQualificationInfo : AopObject
    {
        /// <summary>
        /// 资质图片信息
        /// </summary>
        [XmlArray("images")]
        [XmlArrayItem("group_purchase_image_info")]
        public List<GroupPurchaseImageInfo> Images { get; set; }

        /// <summary>
        /// 资质编码
        /// </summary>
        [XmlElement("qual_code")]
        public string QualCode { get; set; }
    }
}
