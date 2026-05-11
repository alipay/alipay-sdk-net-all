using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationPromoActivityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationPromoActivityQueryModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("device_list")]
        [XmlArrayItem("nfc_device_info")]
        public List<NfcDeviceInfo> DeviceList { get; set; }

        /// <summary>
        /// 服务商侧的商户编号
        /// </summary>
        [XmlElement("out_merchant_no")]
        public string OutMerchantNo { get; set; }
    }
}
