using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RegisterNumberCountDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RegisterNumberCountDTO : AopObject
    {
        /// <summary>
        /// 加号标识， 0：不可加号 1：可加号
        /// </summary>
        [XmlElement("add_number_flag")]
        public string AddNumberFlag { get; set; }

        /// <summary>
        /// 剩余数量
        /// </summary>
        [XmlElement("available_num")]
        public string AvailableNum { get; set; }

        /// <summary>
        /// 号源列表跳转链接
        /// </summary>
        [XmlElement("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 挂号费用，单元：元
        /// </summary>
        [XmlElement("fee")]
        public string Fee { get; set; }

        /// <summary>
        /// 放号时间 格式：2.28 15:00
        /// </summary>
        [XmlElement("number_open_time")]
        public string NumberOpenTime { get; set; }

        /// <summary>
        /// 号源预约状态 1：有号 2: 已约满 3: 停诊 4: 等待放号
        /// </summary>
        [XmlElement("number_status")]
        public string NumberStatus { get; set; }

        /// <summary>
        /// 时间段，上午/下午/中午/夜间
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }

        /// <summary>
        /// 币种符号
        /// </summary>
        [XmlElement("pre_unit")]
        public string PreUnit { get; set; }

        /// <summary>
        /// 排班id
        /// </summary>
        [XmlElement("register_id")]
        public string RegisterId { get; set; }
    }
}
