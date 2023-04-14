using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecruitEnrollMaterial Data Structure.
    /// </summary>
    [Serializable]
    public class RecruitEnrollMaterial : AopObject
    {
        /// <summary>
        /// 报名提交的素材列表。
        /// </summary>
        [XmlArray("materials")]
        [XmlArrayItem("recruit_material_info")]
        public List<RecruitMaterialInfo> Materials { get; set; }
    }
}
