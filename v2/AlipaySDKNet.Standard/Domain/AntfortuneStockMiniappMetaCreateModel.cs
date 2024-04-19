using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneStockMiniappMetaCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneStockMiniappMetaCreateModel : AopObject
    {
        /// <summary>
        /// 蚂蚁展业平台生成的应用id
        /// </summary>
        [XmlElement("ant_app_id")]
        public string AntAppId { get; set; }

        /// <summary>
        /// 渠道id
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 应用id，三方展业平台生成
        /// </summary>
        [XmlElement("inst_app_id")]
        public string InstAppId { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 密钥
        /// </summary>
        [XmlElement("secret")]
        public string Secret { get; set; }
    }
}
