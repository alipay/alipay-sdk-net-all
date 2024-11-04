using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsurancePayExtendParams Data Structure.
    /// </summary>
    [Serializable]
    public class InsurancePayExtendParams : AopObject
    {
        /// <summary>
        /// 用来表示调用接口的渠道方名称，目前为固定的枚举值
        /// </summary>
        [XmlElement("channel_code")]
        public string ChannelCode { get; set; }

        /// <summary>
        /// 医保卡Id；即医保电子凭证授权码
        /// </summary>
        [XmlElement("medical_card_id")]
        public string MedicalCardId { get; set; }

        /// <summary>
        /// 医保卡颁发机构编码；医保电子凭证为NATHSA
        /// </summary>
        [XmlElement("medical_card_inst_id")]
        public string MedicalCardInstId { get; set; }

        /// <summary>
        /// 系统商编号，该参数作为系统商返佣数据提取的依据，请填写系统商签约协议的PID
        /// </summary>
        [XmlElement("sys_service_provider_id")]
        public string SysServiceProviderId { get; set; }
    }
}
