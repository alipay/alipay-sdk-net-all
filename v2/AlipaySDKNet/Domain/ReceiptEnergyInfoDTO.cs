using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReceiptEnergyInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ReceiptEnergyInfoDTO : AopObject
    {
        /// <summary>
        /// 失败错误码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 能量明细。level是detail的时候返回
        /// </summary>
        [XmlArray("energy_generated")]
        [XmlArrayItem("energy_generated_d_t_o")]
        public List<EnergyGeneratedDTO> EnergyGenerated { get; set; }

        /// <summary>
        /// 小票总能量g数
        /// </summary>
        [XmlElement("full_energy")]
        public long FullEnergy { get; set; }

        /// <summary>
        /// 商家外部订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 可重试标识
        /// </summary>
        [XmlElement("retryable")]
        public bool Retryable { get; set; }

        /// <summary>
        /// 发能量请求成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
