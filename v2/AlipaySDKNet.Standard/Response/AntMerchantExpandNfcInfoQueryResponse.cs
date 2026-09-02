using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandNfcInfoQueryResponse.
    /// </summary>
    public class AntMerchantExpandNfcInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// NFC链接对应的码值信息列表
        /// </summary>
        [XmlArray("nfc_info_list")]
        [XmlArrayItem("asset_qrcode_info_d_t_o")]
        public List<AssetQrcodeInfoDTO> NfcInfoList { get; set; }
    }
}
