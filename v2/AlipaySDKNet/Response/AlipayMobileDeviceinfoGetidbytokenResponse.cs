using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobileDeviceinfoGetidbytokenResponse.
    /// </summary>
    public class AlipayMobileDeviceinfoGetidbytokenResponse : AopResponse
    {
        /// <summary>
        /// 蚂蚁金服集团生成的设备id
        /// </summary>
        [XmlElement("apdid")]
        public string Apdid { get; set; }

        /// <summary>
        /// 操作是否成功
        /// </summary>
        [XmlElement("operateresult")]
        public bool Operateresult { get; set; }

        /// <summary>
        /// 阿里巴巴集团安全生产的设备id
        /// </summary>
        [XmlElement("umid")]
        public string Umid { get; set; }
    }
}
