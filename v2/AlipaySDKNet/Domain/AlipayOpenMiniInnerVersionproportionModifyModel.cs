using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerVersionproportionModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerVersionproportionModifyModel : AopObject
    {
        /// <summary>
        /// 业务来源
        /// </summary>
        [XmlElement("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 端id
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 开发者id（平替操作员id）
        /// </summary>
        [XmlElement("dev_id")]
        public string DevId { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 操作员id
        /// </summary>
        [XmlElement("operate_id")]
        public string OperateId { get; set; }

        /// <summary>
        /// 修改值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
