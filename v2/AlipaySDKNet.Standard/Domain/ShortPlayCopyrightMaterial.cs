using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShortPlayCopyrightMaterial Data Structure.
    /// </summary>
    [Serializable]
    public class ShortPlayCopyrightMaterial : AopObject
    {
        /// <summary>
        /// 承诺函及作品清单媒资ID
        /// </summary>
        [XmlArray("commitment_material_ids")]
        [XmlArrayItem("string")]
        public List<string> CommitmentMaterialIds { get; set; }

        /// <summary>
        /// 版权授权证明媒资ID
        /// </summary>
        [XmlArray("license_material_ids")]
        [XmlArrayItem("string")]
        public List<string> LicenseMaterialIds { get; set; }

        /// <summary>
        /// 版权归属证明媒资ID
        /// </summary>
        [XmlArray("ownership_material_ids")]
        [XmlArrayItem("string")]
        public List<string> OwnershipMaterialIds { get; set; }

        /// <summary>
        /// 标题修改申请书媒资ID。审核通过后再次修改标题时必填
        /// </summary>
        [XmlElement("title_modification_material_id")]
        public string TitleModificationMaterialId { get; set; }
    }
}
