using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantNdata Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantNdata : AopObject
    {
        /// <summary>
        /// 相关信息KV返回
        /// </summary>
        [XmlElement("data_content")]
        public string DataContent { get; set; }

        /// <summary>
        /// 设备id，N7为sn，小蓝环和音箱为tagid
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 商户smid
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
