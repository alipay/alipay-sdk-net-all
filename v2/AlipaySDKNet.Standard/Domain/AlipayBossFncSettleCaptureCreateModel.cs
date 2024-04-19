using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncSettleCaptureCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncSettleCaptureCreateModel : AopObject
    {
        /// <summary>
        /// 请款创建单列表
        /// </summary>
        [XmlArray("capture_create_order_list")]
        [XmlArrayItem("capture_create_order")]
        public List<CaptureCreateOrder> CaptureCreateOrderList { get; set; }
    }
}
