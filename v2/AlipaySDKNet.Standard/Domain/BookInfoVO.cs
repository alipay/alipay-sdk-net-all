using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BookInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class BookInfoVO : AopObject
    {
        /// <summary>
        /// 疫苗预约接种时间
        /// </summary>
        [XmlElement("book_time")]
        public string BookTime { get; set; }

        /// <summary>
        /// 外部疫苗id
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 外部交易号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 接种人id
        /// </summary>
        [XmlElement("patient_id")]
        public string PatientId { get; set; }

        /// <summary>
        /// 接种人姓名
        /// </summary>
        [XmlElement("patient_name")]
        public string PatientName { get; set; }

        /// <summary>
        /// 支付方式: 0 线下，1 线上
        /// </summary>
        [XmlElement("pay_method")]
        public long PayMethod { get; set; }

        /// <summary>
        /// 针次信息：第一针、第二针、第三针等
        /// </summary>
        [XmlElement("vaccine_dose")]
        public string VaccineDose { get; set; }
    }
}
