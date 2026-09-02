using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FulfillmentBizVO Data Structure.
    /// </summary>
    [Serializable]
    public class FulfillmentBizVO : AopObject
    {
        /// <summary>
        /// 履约单号
        /// </summary>
        [XmlElement("fulfillment_no")]
        public string FulfillmentNo { get; set; }

        /// <summary>
        /// 履约状态
        /// </summary>
        [XmlElement("fulfillment_status")]
        public string FulfillmentStatus { get; set; }

        /// <summary>
        /// 履约状态描述
        /// </summary>
        [XmlElement("fulfillment_status_desc")]
        public string FulfillmentStatusDesc { get; set; }

        /// <summary>
        /// 履约类型
        /// </summary>
        [XmlElement("fulfillment_type")]
        public string FulfillmentType { get; set; }

        /// <summary>
        /// 商品信息列表
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("examination_item_v_o")]
        public List<ExaminationItemVO> Items { get; set; }

        /// <summary>
        /// 就诊人信息
        /// </summary>
        [XmlArray("patient_infos")]
        [XmlArrayItem("fulfillment_biz_patient_info")]
        public List<FulfillmentBizPatientInfo> PatientInfos { get; set; }

        /// <summary>
        /// 服务包ID
        /// </summary>
        [XmlElement("service_package_id")]
        public string ServicePackageId { get; set; }

        /// <summary>
        /// 服务包名称
        /// </summary>
        [XmlElement("service_package_name")]
        public string ServicePackageName { get; set; }
    }
}
