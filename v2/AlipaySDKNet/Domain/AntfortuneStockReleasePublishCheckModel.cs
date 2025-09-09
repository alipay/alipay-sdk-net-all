using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneStockReleasePublishCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneStockReleasePublishCheckModel : AopObject
    {
        /// <summary>
        /// 当前发布环境
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }

        /// <summary>
        /// 给各机构分配的标识
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 本次发布的包名称
        /// </summary>
        [XmlElement("tgz_name")]
        public string TgzName { get; set; }
    }
}
