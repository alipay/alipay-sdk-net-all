using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceItaskProcessDetailCreateResponse.
    /// </summary>
    public class AlipayIserviceItaskProcessDetailCreateResponse : AopResponse
    {
        /// <summary>
        /// 蚂蚁工单编号
        /// </summary>
        [XmlElement("alipay_process_id")]
        public string AlipayProcessId { get; set; }

        /// <summary>
        /// 工单处理状态，枚举值（CREATED，PROCESSING，COMPLETED，CANCELED）
        /// </summary>
        [XmlElement("alipay_process_status")]
        public string AlipayProcessStatus { get; set; }

        /// <summary>
        /// 工单响应扩展信息，业务属性信息都放置在此字段。最多10个字段。
        /// </summary>
        [XmlArray("extend_field_infos")]
        [XmlArrayItem("extend_field_info")]
        public List<ExtendFieldInfo> ExtendFieldInfos { get; set; }

        /// <summary>
        /// 工单信息唯一标识ID，简写为puid。为app_name、process_no和alipay_process_id共同组合而成，供工单推进接口使用。
        /// </summary>
        [XmlElement("process_unique_id")]
        public string ProcessUniqueId { get; set; }
    }
}
