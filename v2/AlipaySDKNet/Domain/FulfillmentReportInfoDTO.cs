using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FulfillmentReportInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class FulfillmentReportInfoDTO : AopObject
    {
        /// <summary>
        /// 文件流OSS上传接口返回的fileId
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("item_infos")]
        [XmlArrayItem("fulfillment_item_info_d_t_o")]
        public List<FulfillmentItemInfoDTO> ItemInfos { get; set; }

        /// <summary>
        /// 多预约人场景使用
        /// </summary>
        [XmlElement("patient_id")]
        public string PatientId { get; set; }
    }
}
