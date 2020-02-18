using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiSalesKbassetStuffQrcodereturnSyncResponse.
    /// </summary>
    public class KoubeiSalesKbassetStuffQrcodereturnSyncResponse : AopResponse
    {
        /// <summary>
        /// 供应商回传码值被处理结果
        /// </summary>
        [XmlArray("return_qrcode_results")]
        [XmlArrayItem("access_return_qrcode_result")]
        public List<AccessReturnQrcodeResult> ReturnQrcodeResults { get; set; }
    }
}
