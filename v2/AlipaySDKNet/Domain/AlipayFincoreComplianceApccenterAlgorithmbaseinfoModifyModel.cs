using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreComplianceApccenterAlgorithmbaseinfoModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreComplianceApccenterAlgorithmbaseinfoModifyModel : AopObject
    {
        /// <summary>
        /// 平台算法唯一编码
        /// </summary>
        [XmlElement("platform_algorithm_code")]
        public string PlatformAlgorithmCode { get; set; }

        /// <summary>
        /// 平台算法创建时间
        /// </summary>
        [XmlElement("platform_algorithm_create_time")]
        public string PlatformAlgorithmCreateTime { get; set; }

        /// <summary>
        /// 平台算法描述
        /// </summary>
        [XmlElement("platform_algorithm_desc")]
        public string PlatformAlgorithmDesc { get; set; }

        /// <summary>
        /// 平台算法最新迭代唯一编码
        /// </summary>
        [XmlElement("platform_algorithm_last_iteration_code")]
        public string PlatformAlgorithmLastIterationCode { get; set; }

        /// <summary>
        /// 平台算法最新迭代操作用户工号
        /// </summary>
        [XmlElement("platform_algorithm_last_iteration_op_user_emp_no")]
        public string PlatformAlgorithmLastIterationOpUserEmpNo { get; set; }

        /// <summary>
        /// 平台算法修改时间
        /// </summary>
        [XmlElement("platform_algorithm_modify_time")]
        public string PlatformAlgorithmModifyTime { get; set; }

        /// <summary>
        /// 平台算法名称
        /// </summary>
        [XmlElement("platform_algorithm_name")]
        public string PlatformAlgorithmName { get; set; }

        /// <summary>
        /// 平台算法负责人工号
        /// </summary>
        [XmlElement("platform_algorithm_owner_emp_no")]
        public string PlatformAlgorithmOwnerEmpNo { get; set; }

        /// <summary>
        /// 平台算法来源
        /// </summary>
        [XmlElement("platform_algorithm_source")]
        public string PlatformAlgorithmSource { get; set; }

        /// <summary>
        /// 平台算法状态
        /// </summary>
        [XmlElement("platform_algorithm_status")]
        public string PlatformAlgorithmStatus { get; set; }
    }
}
