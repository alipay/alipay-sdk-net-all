using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantQipanCrowdpoolCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantQipanCrowdpoolCreateModel : AopObject
    {
        /// <summary>
        /// 安全应用范围，参考文档<a href="https://opendocs.alipay.com/pre-open/04phhq" target="_blank">安全应用范围枚举</a>
        /// </summary>
        [XmlArray("apply_channel_list")]
        [XmlArrayItem("string")]
        public List<string> ApplyChannelList { get; set; }

        /// <summary>
        /// 需要求交的人群编号列表
        /// </summary>
        [XmlArray("crowd_code_list")]
        [XmlArrayItem("string")]
        public List<string> CrowdCodeList { get; set; }

        /// <summary>
        /// 人群名称
        /// </summary>
        [XmlElement("crowd_name")]
        public string CrowdName { get; set; }

        /// <summary>
        /// 交并差操作，说明具体操作的动作
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }
    }
}
