using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EduCheckInRecord Data Structure.
    /// </summary>
    [Serializable]
    public class EduCheckInRecord : AopObject
    {
        /// <summary>
        /// 签到图片链接
        /// </summary>
        [XmlElement("check_in_picture")]
        public string CheckInPicture { get; set; }

        /// <summary>
        /// 签到结果
        /// </summary>
        [XmlElement("check_in_result")]
        public string CheckInResult { get; set; }

        /// <summary>
        /// 签到来源类型
        /// </summary>
        [XmlElement("check_in_source_type")]
        public string CheckInSourceType { get; set; }

        /// <summary>
        /// 签到状态
        /// </summary>
        [XmlElement("check_in_status")]
        public string CheckInStatus { get; set; }

        /// <summary>
        /// 签到时间
        /// </summary>
        [XmlElement("check_in_time")]
        public string CheckInTime { get; set; }

        /// <summary>
        /// 签到类型
        /// </summary>
        [XmlElement("check_in_type")]
        public string CheckInType { get; set; }

        /// <summary>
        /// 签退图片url
        /// </summary>
        [XmlElement("check_out_picture")]
        public string CheckOutPicture { get; set; }

        /// <summary>
        /// 签退时间
        /// </summary>
        [XmlElement("check_out_time")]
        public string CheckOutTime { get; set; }

        /// <summary>
        /// 学号或工号
        /// </summary>
        [XmlElement("employee_no")]
        public string EmployeeNo { get; set; }

        /// <summary>
        /// 机构内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 部门节点id
        /// </summary>
        [XmlElement("node_id")]
        public string NodeId { get; set; }

        /// <summary>
        /// 部门节点名称
        /// </summary>
        [XmlElement("node_name")]
        public string NodeName { get; set; }

        /// <summary>
        /// 位置id
        /// </summary>
        [XmlElement("place_id")]
        public string PlaceId { get; set; }

        /// <summary>
        /// 位置名称
        /// </summary>
        [XmlElement("place_name")]
        public string PlaceName { get; set; }

        /// <summary>
        /// 用户花名册id
        /// </summary>
        [XmlElement("roster_id")]
        public string RosterId { get; set; }

        /// <summary>
        /// 签到记录id
        /// </summary>
        [XmlElement("user_check_in_id")]
        public string UserCheckInId { get; set; }
    }
}
