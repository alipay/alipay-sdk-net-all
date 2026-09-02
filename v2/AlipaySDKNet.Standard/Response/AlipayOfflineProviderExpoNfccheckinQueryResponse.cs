using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderExpoNfccheckinQueryResponse.
    /// </summary>
    public class AlipayOfflineProviderExpoNfccheckinQueryResponse : AopResponse
    {
        /// <summary>
        /// 活动code
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 外滩大会
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("nfc_expo_check_place_item_vos")]
        [XmlArrayItem("nfc_expo_check_place_item_v_o")]
        public List<NfcExpoCheckPlaceItemVO> NfcExpoCheckPlaceItemVos { get; set; }
    }
}
