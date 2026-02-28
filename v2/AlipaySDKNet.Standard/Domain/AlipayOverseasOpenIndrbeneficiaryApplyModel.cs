using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasOpenIndrbeneficiaryApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasOpenIndrbeneficiaryApplyModel : AopObject
    {
        /// <summary>
        /// 机构地址信息
        /// </summary>
        [XmlElement("address")]
        public IndrAddress Address { get; set; }

        /// <summary>
        /// 机构简称
        /// </summary>
        [XmlElement("beneficiary_abb_name")]
        public string BeneficiaryAbbName { get; set; }

        /// <summary>
        /// 机构本地名称
        /// </summary>
        [XmlElement("beneficiary_local_name")]
        public string BeneficiaryLocalName { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        [XmlElement("beneficiary_name")]
        public string BeneficiaryName { get; set; }

        /// <summary>
        /// 1. 大学：COLLEGE 2. 高中：HIGH_SCHOOL 3. 房东：LANDLORD 4. 租房服务商：RENTING_ISV
        /// </summary>
        [XmlElement("beneficiary_sub_type")]
        public string BeneficiarySubType { get; set; }

        /// <summary>
        /// 1. 学校：SCHOOL 2. 租赁机构：RENTING
        /// </summary>
        [XmlElement("beneficiary_type")]
        public string BeneficiaryType { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 文件list
        /// </summary>
        [XmlArray("file_list")]
        [XmlArrayItem("indr_file_info")]
        public List<IndrFileInfo> FileList { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [XmlElement("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 1. 留学场景：TUITION 2. 租房场景：HOUSE_RENTAL
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 网址
        /// </summary>
        [XmlElement("websites")]
        public string Websites { get; set; }
    }
}
