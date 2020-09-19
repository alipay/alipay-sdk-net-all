using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialQuestionnareGrayUpgradeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialQuestionnareGrayUpgradeModel : AopObject
    {
        /// <summary>
        /// 业务扩展字段
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 灰度比例
        /// </summary>
        [XmlElement("gray_percent")]
        public string GrayPercent { get; set; }

        /// <summary>
        /// 哥伦布问券任务Id
        /// </summary>
        [XmlElement("qstn_id")]
        public string QstnId { get; set; }
    }
}
