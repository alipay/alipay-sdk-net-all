using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EtcVehicleOwnerInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EtcVehicleOwnerInfo : AopObject
    {
        /// <summary>
        /// 车主地址信息包含省市区(身份证地址)
        /// </summary>
        [XmlElement("vi_owner_address")]
        public string ViOwnerAddress { get; set; }

        /// <summary>
        /// 身份证有效期结束时间，注意并不全是日期格式，有”长期“的情况
        /// </summary>
        [XmlElement("vi_owner_cert_end_date")]
        public string ViOwnerCertEndDate { get; set; }

        /// <summary>
        /// 车主证件号码
        /// </summary>
        [XmlElement("vi_owner_cert_no")]
        public string ViOwnerCertNo { get; set; }

        /// <summary>
        /// 身份证有效期开始时间
        /// </summary>
        [XmlElement("vi_owner_cert_start_date")]
        public string ViOwnerCertStartDate { get; set; }

        /// <summary>
        /// 车主证件类型，当前只支持身份证 101-身份证
        /// </summary>
        [XmlElement("vi_owner_cert_type")]
        public string ViOwnerCertType { get; set; }

        /// <summary>
        /// 用户所在城市名称
        /// </summary>
        [XmlElement("vi_owner_city")]
        public string ViOwnerCity { get; set; }

        /// <summary>
        /// 车主联系电话
        /// </summary>
        [XmlElement("vi_owner_contact")]
        public string ViOwnerContact { get; set; }

        /// <summary>
        /// 用户所在地区名称
        /// </summary>
        [XmlElement("vi_owner_district")]
        public string ViOwnerDistrict { get; set; }

        /// <summary>
        /// 车主姓名
        /// </summary>
        [XmlElement("vi_owner_name")]
        public string ViOwnerName { get; set; }

        /// <summary>
        /// 用户所在地址省份名称
        /// </summary>
        [XmlElement("vi_owner_province")]
        public string ViOwnerProvince { get; set; }

        /// <summary>
        /// 车主类型 PRESONAL：个人用户; ENTERPRISE：企业用户
        /// </summary>
        [XmlElement("vi_owner_type")]
        public string ViOwnerType { get; set; }
    }
}
