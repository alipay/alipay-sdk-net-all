using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BrandAuthMaterialInfoOpenApi Data Structure.
    /// </summary>
    [Serializable]
    public class BrandAuthMaterialInfoOpenApi : AopObject
    {
        /// <summary>
        /// 授权级别 L1:一级授权 L2:二级授权 L3:三级授权 L4:四级及以上
        /// </summary>
        [XmlElement("auth_level")]
        public string AuthLevel { get; set; }

        /// <summary>
        /// 是否属于个人 true：是个人，false：非个人  当传入brand_manage_type，且brand_manage_type=BRAND_AUTH时必选
        /// </summary>
        [XmlElement("belong_person")]
        public bool BelongPerson { get; set; }

        /// <summary>
        /// 品牌经营类型 PRIVATE_BRAND：自有品牌 BRAND_AUTH：品牌授权 DISTRIBUTE_AUTH：经销授权
        /// </summary>
        [XmlElement("brand_manage_type")]
        public string BrandManageType { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("brand_relation_proof")]
        [XmlArrayItem("brand_file_info_open_api")]
        public List<BrandFileInfoOpenApi> BrandRelationProof { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("id_card_file")]
        [XmlArrayItem("brand_file_info_open_api")]
        public List<BrandFileInfoOpenApi> IdCardFile { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("passport")]
        [XmlArrayItem("brand_file_info_open_api")]
        public List<BrandFileInfoOpenApi> Passport { get; set; }

        /// <summary>
        /// 个人身份证明 ID_CARD：个人身份证 PASSPORT：个人护照  当传入brand_manage_type，且brand_manage_type=BRAND_AUTH时必选
        /// </summary>
        [XmlElement("person_certification")]
        public string PersonCertification { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("qualifications")]
        [XmlArrayItem("brand_file_info_open_api")]
        public List<BrandFileInfoOpenApi> Qualifications { get; set; }
    }
}
