using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BrandAuthAdditionalInfoOpenApi Data Structure.
    /// </summary>
    [Serializable]
    public class BrandAuthAdditionalInfoOpenApi : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("brand_app_infos")]
        [XmlArrayItem("brand_app_info_open_api")]
        public List<BrandAppInfoOpenApi> BrandAppInfos { get; set; }

        /// <summary>
        /// 品牌logo
        /// </summary>
        [XmlElement("brand_op_logo")]
        public BrandFileInfoOpenApi BrandOpLogo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("brand_use_scene")]
        [XmlArrayItem("string")]
        public List<string> BrandUseScene { get; set; }
    }
}
