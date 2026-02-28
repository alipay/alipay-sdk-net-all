using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHdfcheckQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalHdfcheckQueryResponse : AopResponse
    {
        /// <summary>
        /// 科室名称
        /// </summary>
        [XmlElement("apply_department_name")]
        public string ApplyDepartmentName { get; set; }

        /// <summary>
        /// 申请时间
        /// </summary>
        [XmlElement("apply_time")]
        public string ApplyTime { get; set; }

        /// <summary>
        /// 诊断内容
        /// </summary>
        [XmlElement("diagnosis_info")]
        public GetInspectionDetailDiagnosisInfo DiagnosisInfo { get; set; }

        /// <summary>
        /// hdf的履约单号
        /// </summary>
        [XmlElement("hdf_check_no")]
        public string HdfCheckNo { get; set; }

        /// <summary>
        /// hdf的用户年龄
        /// </summary>
        [XmlElement("hdf_user_age")]
        public string HdfUserAge { get; set; }

        /// <summary>
        /// hdf的用户号码
        /// </summary>
        [XmlElement("hdf_user_mb")]
        public string HdfUserMb { get; set; }

        /// <summary>
        /// hdf的用户名
        /// </summary>
        [XmlElement("hdf_user_name")]
        public string HdfUserName { get; set; }

        /// <summary>
        /// hdf的用户编码
        /// </summary>
        [XmlElement("hdf_user_no")]
        public string HdfUserNo { get; set; }

        /// <summary>
        /// 用户性别
        /// </summary>
        [XmlElement("hdf_user_sex")]
        public string HdfUserSex { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("item_info_list")]
        [XmlArrayItem("get_inspection_detail_item_info")]
        public List<GetInspectionDetailItemInfo> ItemInfoList { get; set; }
    }
}
