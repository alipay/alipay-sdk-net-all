using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandTerminateConsultresultSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandTerminateConsultresultSyncModel : AopObject
    {
        /// <summary>
        /// 消息体中batchNO
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 消息体中bizNo
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 咨询类型
        /// </summary>
        [XmlElement("consult_type")]
        public string ConsultType { get; set; }

        /// <summary>
        /// 撤销状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 供应商id
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }
    }
}
