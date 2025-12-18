using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalOuterorderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalOuterorderCreateModel : AopObject
    {
        /// <summary>
        /// 业务身份
        /// </summary>
        [XmlElement("biz_identity")]
        public string BizIdentity { get; set; }

        /// <summary>
        /// 下发业务类型
        /// </summary>
        [XmlElement("consult_business")]
        public string ConsultBusiness { get; set; }

        /// <summary>
        /// 好大夫生成的履约单id
        /// </summary>
        [XmlElement("fulfillment_order_id")]
        public string FulfillmentOrderId { get; set; }

        /// <summary>
        /// 好大夫用户user
        /// </summary>
        [XmlElement("hdf_user")]
        public string HdfUser { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("medical_record_info_list")]
        [XmlArrayItem("h_d_f_medical_record_info")]
        public List<HDFMedicalRecordInfo> MedicalRecordInfoList { get; set; }

        /// <summary>
        /// 一方userid
        /// </summary>
        [XmlElement("partner_user")]
        public string PartnerUser { get; set; }

        /// <summary>
        /// 好大夫的患者信息
        /// </summary>
        [XmlElement("patient_info")]
        public HDFPatientInfo PatientInfo { get; set; }

        /// <summary>
        /// 信息
        /// </summary>
        [XmlElement("transer_info")]
        public string TranserInfo { get; set; }
    }
}
