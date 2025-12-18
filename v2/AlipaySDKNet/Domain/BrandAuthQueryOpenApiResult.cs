using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BrandAuthQueryOpenApiResult Data Structure.
    /// </summary>
    [Serializable]
    public class BrandAuthQueryOpenApiResult : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("brand_app_list")]
        [XmlArrayItem("brand_app_info_open_api")]
        public List<BrandAppInfoOpenApi> BrandAppList { get; set; }

        /// <summary>
        /// 品牌id
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 品牌logo
        /// </summary>
        [XmlElement("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 品牌所有人
        /// </summary>
        [XmlElement("owner_name")]
        public string OwnerName { get; set; }

        /// <summary>
        /// true：标准品牌 false：非标品牌
        /// </summary>
        [XmlElement("standard")]
        public bool Standard { get; set; }

        /// <summary>
        /// 0：已删除 1：已激活 2：审批中 3：已驳回 4：已失效 5：激活时更新审批中 6：授权即将过期 7：失效时更新审批中
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
