using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodCommonNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsAutoAutoinsprodCommonNotifyModel : AopObject
    {
        /// <summary>
        /// 业务内容 具体内容按照业务类型对应的key值传输
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// AUTO_LEADS_STATUS_SYNC：新电焊名单状态同步服务
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }
    }
}
