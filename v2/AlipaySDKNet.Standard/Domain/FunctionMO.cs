using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FunctionMO Data Structure.
    /// </summary>
    [Serializable]
    public class FunctionMO : AopObject
    {
        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 云函数名称
        /// </summary>
        [XmlElement("function_name")]
        public string FunctionName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 运行环境  - nodejs12  - nodejs18  - python39  - php74  - java17
        /// </summary>
        [XmlElement("image_name")]
        public string ImageName { get; set; }

        /// <summary>
        /// 规格配置  - 0.25c0.5g  - 0.5c1g  - 1c2g
        /// </summary>
        [XmlElement("quota_name")]
        public string QuotaName { get; set; }

        /// <summary>
        /// 发布状态值
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
