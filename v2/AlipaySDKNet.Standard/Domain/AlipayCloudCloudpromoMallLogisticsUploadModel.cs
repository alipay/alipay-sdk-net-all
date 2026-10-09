using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoMallLogisticsUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoMallLogisticsUploadModel : AopObject
    {
        /// <summary>
        /// 公司代码
        /// </summary>
        [XmlElement("cp_code")]
        public string CpCode { get; set; }

        /// <summary>
        /// 纠纷id
        /// </summary>
        [XmlElement("dispute_id")]
        public string DisputeId { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [XmlElement("logistics_no")]
        public string LogisticsNo { get; set; }
    }
}
