using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandDeliveryProcessSyncResponse.
    /// </summary>
    public class AntMerchantExpandDeliveryProcessSyncResponse : AopResponse
    {
        /// <summary>
        /// 响应参数
        /// </summary>
        [XmlElement("result")]
        public AssetResult Result { get; set; }
    }
}
