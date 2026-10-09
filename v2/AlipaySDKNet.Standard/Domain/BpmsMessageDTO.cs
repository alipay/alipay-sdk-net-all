using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BpmsMessageDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BpmsMessageDTO : AopObject
    {
        /// <summary>
        /// bpms消息体
        /// </summary>
        [XmlElement("alipmc_metaq_message_open_mq_dto")]
        public AlipmcMetaqMessageOpenMqDTO AlipmcMetaqMessageOpenMqDto { get; set; }

        /// <summary>
        /// bpms流程实例
        /// </summary>
        [XmlElement("alipmc_process_instance_open_mq_dto")]
        public AlipmcProcessInstanceOpenMqDTO AlipmcProcessInstanceOpenMqDto { get; set; }

        /// <summary>
        /// 平台code
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// bpms流程变量
        /// </summary>
        [XmlArray("variables_of_process_instance_open_mq_dto_list")]
        [XmlArrayItem("variables_of_process_instance_open_mq_d_t_o")]
        public List<VariablesOfProcessInstanceOpenMqDTO> VariablesOfProcessInstanceOpenMqDtoList { get; set; }
    }
}
