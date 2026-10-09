using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenIdConfigRequestExt Data Structure.
    /// </summary>
    [Serializable]
    public class OpenIdConfigRequestExt : AopObject
    {
        /// <summary>
        /// 业务ID
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 计算类型
        /// </summary>
        [XmlElement("cal_type")]
        public string CalType { get; set; }

        /// <summary>
        /// 执行模式
        /// </summary>
        [XmlElement("execute_mode")]
        public string ExecuteMode { get; set; }

        /// <summary>
        /// 灰度模式
        /// </summary>
        [XmlElement("gray_mode")]
        public string GrayMode { get; set; }

        /// <summary>
        /// 灰度比例
        /// </summary>
        [XmlElement("gray_ratio")]
        public string GrayRatio { get; set; }

        /// <summary>
        /// 灰度用户
        /// </summary>
        [XmlArray("gray_users")]
        [XmlArrayItem("string")]
        public List<string> GrayUsers { get; set; }
    }
}
