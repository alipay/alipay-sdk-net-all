using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarfinRegistrationTransferInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CarfinRegistrationTransferInfo : AopObject
    {
        /// <summary>
        /// 获得方式
        /// </summary>
        [XmlElement("acquisition_method")]
        public string AcquisitionMethod { get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [XmlElement("social_code")]
        public string SocialCode { get; set; }

        /// <summary>
        /// 转移人姓名
        /// </summary>
        [XmlElement("transfer_name")]
        public string TransferName { get; set; }

        /// <summary>
        /// 转移登记日期
        /// </summary>
        [XmlElement("transfer_registration_date")]
        public string TransferRegistrationDate { get; set; }

        /// <summary>
        /// 机动车登记编号
        /// </summary>
        [XmlElement("vehicle_registration_number")]
        public string VehicleRegistrationNumber { get; set; }
    }
}
