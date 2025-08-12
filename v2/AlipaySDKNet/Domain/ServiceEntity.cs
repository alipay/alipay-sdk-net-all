using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceEntity Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceEntity : AopObject
    {
        /// <summary>
        /// 商品所属的小程序appId
        /// </summary>
        [XmlElement("service_entity_app_id")]
        public string ServiceEntityAppId { get; set; }

        /// <summary>
        /// 商品所属的小程序名称
        /// </summary>
        [XmlElement("service_entity_app_name")]
        public string ServiceEntityAppName { get; set; }

        /// <summary>
        /// 小程序的URL
        /// </summary>
        [XmlElement("service_entity_app_url")]
        public string ServiceEntityAppUrl { get; set; }

        /// <summary>
        /// 实体描述
        /// </summary>
        [XmlElement("service_entity_desc")]
        public string ServiceEntityDesc { get; set; }

        /// <summary>
        /// 商品上绑定的落地也相关信息
        /// </summary>
        [XmlArray("service_entity_landing_page")]
        [XmlArrayItem("landing_type_dto")]
        public List<LandingTypeDto> ServiceEntityLandingPage { get; set; }

        /// <summary>
        /// 实体名称
        /// </summary>
        [XmlElement("service_entity_name")]
        public string ServiceEntityName { get; set; }

        /// <summary>
        /// 实体NO，是一个实体的唯一键
        /// </summary>
        [XmlElement("service_entity_no")]
        public string ServiceEntityNo { get; set; }

        /// <summary>
        /// 实体的outId，跟实体类型和实体来源一起组成entity_no
        /// </summary>
        [XmlElement("service_entity_out_id")]
        public string ServiceEntityOutId { get; set; }

        /// <summary>
        /// 用于表示实体来源
        /// </summary>
        [XmlElement("service_entity_out_source")]
        public string ServiceEntityOutSource { get; set; }

        /// <summary>
        /// 实体主图图片
        /// </summary>
        [XmlElement("service_entity_picture")]
        public string ServiceEntityPicture { get; set; }

        /// <summary>
        /// 实体子图图片列表
        /// </summary>
        [XmlArray("service_entity_picture_list")]
        [XmlArrayItem("string")]
        public List<string> ServiceEntityPictureList { get; set; }

        /// <summary>
        /// 交互落地页URL
        /// </summary>
        [XmlElement("service_entity_target_url")]
        public string ServiceEntityTargetUrl { get; set; }

        /// <summary>
        /// 第二落地页:商品提报落地页和官方商详页
        /// </summary>
        [XmlElement("service_entity_target_url_snd")]
        public string ServiceEntityTargetUrlSnd { get; set; }

        /// <summary>
        /// 标识实体的类型，可以是电商商品、金融商品、保险服务三种类型
        /// </summary>
        [XmlElement("service_entity_type")]
        public string ServiceEntityType { get; set; }

        /// <summary>
        /// 实体视频列表
        /// </summary>
        [XmlArray("service_entity_video_list")]
        [XmlArrayItem("string")]
        public List<string> ServiceEntityVideoList { get; set; }

        /// <summary>
        /// 实体白底图
        /// </summary>
        [XmlElement("service_entity_white_picture")]
        public string ServiceEntityWhitePicture { get; set; }
    }
}
