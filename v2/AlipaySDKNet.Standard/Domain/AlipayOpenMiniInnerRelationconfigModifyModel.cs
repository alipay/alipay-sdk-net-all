using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerRelationconfigModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerRelationconfigModifyModel : AopObject
    {
        /// <summary>
        /// 业务来源
        /// </summary>
        [XmlElement("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 开发者id（平替操作员id）
        /// </summary>
        [XmlElement("dev_id")]
        public string DevId { get; set; }

        /// <summary>
        /// 业务小程序id
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 操作员id
        /// </summary>
        [XmlElement("operate_id")]
        public string OperateId { get; set; }

        /// <summary>
        /// 允许所有小程序跳转
        /// </summary>
        [XmlElement("un_limited")]
        public bool UnLimited { get; set; }

        /// <summary>
        /// 互跳白名单
        /// </summary>
        [XmlElement("white_list")]
        public string WhiteList { get; set; }
    }
}
