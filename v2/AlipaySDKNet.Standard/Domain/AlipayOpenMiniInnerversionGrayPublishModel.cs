using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionGrayPublishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionGrayPublishModel : AopObject
    {
        /// <summary>
        /// 业务来源
        /// </summary>
        [XmlElement("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 小程序版本
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 待邀测应用列表，灰度插件时使用，如无邀测必要请不要传入
        /// </summary>
        [XmlArray("beta_app_id_list")]
        [XmlArrayItem("string")]
        public List<string> BetaAppIdList { get; set; }

        /// <summary>
        /// 端信息
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 灰度值
        /// </summary>
        [XmlElement("gray_strategy")]
        public string GrayStrategy { get; set; }

        /// <summary>
        /// 小程序ID，仅特殊场景使用，普通业务方无需关注该参数
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序所属PID
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
