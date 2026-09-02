using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsultDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ConsultDetail : AopObject
    {
        /// <summary>
        /// 区域偏好
        /// </summary>
        [XmlElement("area_preference")]
        public string AreaPreference { get; set; }

        /// <summary>
        /// 预算范围/元
        /// </summary>
        [XmlElement("budget_range")]
        public string BudgetRange { get; set; }

        /// <summary>
        /// 期望入住时间
        /// </summary>
        [XmlElement("move_in_date")]
        public string MoveInDate { get; set; }

        /// <summary>
        /// 其他诉求
        /// </summary>
        [XmlElement("other_requirements")]
        public string OtherRequirements { get; set; }

        /// <summary>
        /// 房型偏好
        /// </summary>
        [XmlElement("room_type")]
        public string RoomType { get; set; }
    }
}
