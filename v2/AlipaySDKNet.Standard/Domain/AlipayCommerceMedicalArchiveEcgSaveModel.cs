using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalArchiveEcgSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalArchiveEcgSaveModel : AopObject
    {
        /// <summary>
        /// 认证令牌
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 数据来源
        /// </summary>
        [XmlElement("data_source")]
        public string DataSource { get; set; }

        /// <summary>
        /// 数据类型
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("ecg_report_datail")]
        [XmlArrayItem("ecg_report_datail")]
        public List<EcgReportDatail> EcgReportDatail { get; set; }

        /// <summary>
        /// 采集成员id
        /// </summary>
        [XmlElement("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
