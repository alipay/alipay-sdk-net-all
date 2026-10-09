using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandIotdeviceOnlinedataUploadResponse.
    /// </summary>
    public class AntMerchantExpandIotdeviceOnlinedataUploadResponse : AopResponse
    {
        /// <summary>
        /// 商户合作设备在线时间回传结果
        /// </summary>
        [XmlElement("onlinedata_upload_result")]
        public bool OnlinedataUploadResult { get; set; }
    }
}
