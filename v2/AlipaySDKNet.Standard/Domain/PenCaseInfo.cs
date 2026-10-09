using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PenCaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PenCaseInfo : AopObject
    {
        /// <summary>
        /// 社会统一信用代码
        /// </summary>
        [XmlElement("credit_code")]
        public string CreditCode { get; set; }

        /// <summary>
        /// 违法行为类型
        /// </summary>
        [XmlElement("illegact_type")]
        public string IllegactType { get; set; }

        /// <summary>
        /// 公示日期. yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("open_date")]
        public string OpenDate { get; set; }

        /// <summary>
        /// 处罚机关
        /// </summary>
        [XmlElement("pen_auth")]
        public string PenAuth { get; set; }

        /// <summary>
        /// 行政处罚决定书内容
        /// </summary>
        [XmlElement("pen_con")]
        public string PenCon { get; set; }

        /// <summary>
        /// 处罚决定书文号
        /// </summary>
        [XmlElement("pen_dec_no")]
        public string PenDecNo { get; set; }

        /// <summary>
        /// 处罚决定书签发日期. 格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("pendeciss_date")]
        public string PendecissDate { get; set; }

        /// <summary>
        /// 当事人姓名
        /// </summary>
        [XmlElement("unit_name")]
        public string UnitName { get; set; }
    }
}
