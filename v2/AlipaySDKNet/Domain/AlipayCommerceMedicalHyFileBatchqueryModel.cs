using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHyFileBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHyFileBatchqueryModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("file_list")]
        [XmlArrayItem("file_item")]
        public List<FileItem> FileList { get; set; }

        /// <summary>
        /// 支付宝侧问诊订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 互联网医院平台编码
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }
    }
}
