using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationPromoActivityQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationPromoActivityQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("device_act_info_list")]
        [XmlArrayItem("nfc_device_activity_info")]
        public List<NfcDeviceActivityInfo> DeviceActInfoList { get; set; }

        /// <summary>
        /// 服务商侧的商户编号
        /// </summary>
        [XmlElement("out_merchant_no")]
        public string OutMerchantNo { get; set; }
    }
}
