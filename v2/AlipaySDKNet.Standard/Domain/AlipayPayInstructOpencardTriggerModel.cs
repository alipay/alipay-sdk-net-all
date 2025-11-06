using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayInstructOpencardTriggerModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayInstructOpencardTriggerModel : AopObject
    {
        /// <summary>
        /// ABCP请求超时时间，单位毫秒，默认值为2 * 60 * 1000L(2分钟)超时，-1表示永不超时，可以根据业务情况修改
        /// </summary>
        [XmlElement("bpaas_ipc_timeout")]
        public string BpaasIpcTimeout { get; set; }

        /// <summary>
        /// 发起收款:show 关闭收银界面:pop
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// opencard 打开会员卡
        /// </summary>
        [XmlElement("page")]
        public string Page { get; set; }

        /// <summary>
        /// 开卡调用参数
        /// </summary>
        [XmlElement("params")]
        public Params Params { get; set; }

        /// <summary>
        /// POS 设备唯一标识，建议取 POS 设备 SN 编号，保证每个设备唯一
        /// </summary>
        [XmlElement("pos_id")]
        public string PosId { get; set; }
    }
}
