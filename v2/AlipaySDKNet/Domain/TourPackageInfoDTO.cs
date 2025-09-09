using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TourPackageInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TourPackageInfoDTO : AopObject
    {
        /// <summary>
        /// 出发时间
        /// </summary>
        [XmlElement("departure_time")]
        public string DepartureTime { get; set; }

        /// <summary>
        /// 出行人身份证信息
        /// </summary>
        [XmlElement("identity_card")]
        public string IdentityCard { get; set; }

        /// <summary>
        /// 出行人电话
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 出行人姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 人数信息
        /// </summary>
        [XmlElement("population")]
        public string Population { get; set; }

        /// <summary>
        /// 回程时间
        /// </summary>
        [XmlElement("return_time")]
        public string ReturnTime { get; set; }
    }
}
