using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceItaskProcessDetailModifyResponse.
    /// </summary>
    public class AlipayIserviceItaskProcessDetailModifyResponse : AopResponse
    {
        /// <summary>
        /// 蚂蚁工单编号
        /// </summary>
        [XmlElement("alipay_process_id")]
        public string AlipayProcessId { get; set; }

        /// <summary>
        /// 工单处理状态，枚举（CREATED，PROCESSING，COMPLETED，CANCELED）
        /// </summary>
        [XmlElement("alipay_process_status")]
        public string AlipayProcessStatus { get; set; }

        /// <summary>
        /// 外部工单业务扩展字段，业务属性信息都放置在此字段。最多10个字段。
        /// </summary>
        [XmlArray("extend_field_infos")]
        [XmlArrayItem("extend_field_info")]
        public List<ExtendFieldInfo> ExtendFieldInfos { get; set; }
    }
}
