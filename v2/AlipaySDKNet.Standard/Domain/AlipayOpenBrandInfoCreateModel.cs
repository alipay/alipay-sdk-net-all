using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenBrandInfoCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenBrandInfoCreateModel : AopObject
    {
        /// <summary>
        /// 品牌英文名/英文名至少填写一个
        /// </summary>
        [XmlElement("brand_chs_name")]
        public string BrandChsName { get; set; }

        /// <summary>
        /// 品牌英文名/英文名至少填写一个
        /// </summary>
        [XmlElement("brand_eng_name")]
        public string BrandEngName { get; set; }

        /// <summary>
        /// 修改品牌时传入，新建不需要传
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 关于品牌的文字描述
        /// </summary>
        [XmlElement("brand_story")]
        public string BrandStory { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("brand_trademark_infos")]
        [XmlArrayItem("brand_trademark_info_open_api")]
        public List<BrandTrademarkInfoOpenApi> BrandTrademarkInfos { get; set; }

        /// <summary>
        /// 需传入ant.merchant.expand.indirect.image.upload 接口上传图片后得到的 image_id。
        /// </summary>
        [XmlElement("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 品牌归属人，比如商标的注册人
        /// </summary>
        [XmlElement("owner_name")]
        public string OwnerName { get; set; }

        /// <summary>
        /// true：标准品牌 false：非标准品牌
        /// </summary>
        [XmlElement("standard")]
        public bool Standard { get; set; }

        /// <summary>
        /// 非标品牌信息
        /// </summary>
        [XmlElement("unstandard_brand_info")]
        public UnStandardBrandAddInfoOpenApi UnstandardBrandInfo { get; set; }
    }
}
