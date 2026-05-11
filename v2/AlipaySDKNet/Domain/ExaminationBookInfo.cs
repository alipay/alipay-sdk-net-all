using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExaminationBookInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ExaminationBookInfo : AopObject
    {
        /// <summary>
        /// 预约结束时间
        /// </summary>
        [XmlElement("book_end_time")]
        public string BookEndTime { get; set; }

        /// <summary>
        /// 预约开始时间 日期
        /// </summary>
        [XmlElement("book_start_time")]
        public string BookStartTime { get; set; }

        /// <summary>
        /// 患者性别
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("id_card")]
        public string IdCard { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("id_type")]
        public string IdType { get; set; }

        /// <summary>
        /// 患者姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 预约门店地址
        /// </summary>
        [XmlElement("store_address")]
        public string StoreAddress { get; set; }

        /// <summary>
        /// 预约门店名称
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 预约时间
        /// </summary>
        [XmlElement("time")]
        public string Time { get; set; }
    }
}
