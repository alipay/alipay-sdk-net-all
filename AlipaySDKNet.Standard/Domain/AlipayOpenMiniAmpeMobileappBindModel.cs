using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniAmpeMobileappBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAmpeMobileappBindModel : AopObject
    {
        /// <summary>
        /// 移动应用签名
        /// </summary>
        [XmlElement("app_sign")]
        public string AppSign { get; set; }

        /// <summary>
        /// 移动应用id
        /// </summary>
        [XmlElement("mobile_app_id")]
        public string MobileAppId { get; set; }

        /// <summary>
        /// 产品ID列表
        /// </summary>
        [XmlArray("product_id_list")]
        [XmlArrayItem("number")]
        public List<long> ProductIdList { get; set; }

        /// <summary>
        /// 场景码，申请后平台分配
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
