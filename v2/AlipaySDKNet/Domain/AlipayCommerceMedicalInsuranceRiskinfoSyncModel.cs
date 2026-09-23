using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceRiskinfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInsuranceRiskinfoSyncModel : AopObject
    {
        /// <summary>
        /// 保司类型，非枚举类型
        /// </summary>
        [XmlElement("company_type")]
        public string CompanyType { get; set; }

        /// <summary>
        /// 原权益流水号
        /// </summary>
        [XmlElement("old_serial_no")]
        public string OldSerialNo { get; set; }

        /// <summary>
        /// 销售机构代码
        /// </summary>
        [XmlElement("organization_code")]
        public string OrganizationCode { get; set; }

        /// <summary>
        /// 家庭单特有
        /// </summary>
        [XmlElement("parent_serial_no")]
        public string ParentSerialNo { get; set; }

        /// <summary>
        /// 家庭单特有，非枚举类型
        /// </summary>
        [XmlElement("parent_status")]
        public string ParentStatus { get; set; }

        /// <summary>
        /// 产品编号
        /// </summary>
        [XmlElement("prod_no")]
        public string ProdNo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("project_list")]
        [XmlArrayItem("project_info")]
        public List<ProjectInfo> ProjectList { get; set; }

        /// <summary>
        /// 销售方式，非枚举类型
        /// </summary>
        [XmlElement("sales_method")]
        public string SalesMethod { get; set; }

        /// <summary>
        /// 权益流水号 对应同一权益需保持唯一
        /// </summary>
        [XmlElement("serial_no")]
        public string SerialNo { get; set; }

        /// <summary>
        /// 权益状态，非枚举类型
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
