using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneFlowcardBindcardNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneFlowcardBindcardNotifyModel : AopObject
    {
        /// <summary>
        /// 支付宝的服务记录编号
        /// </summary>
        [XmlElement("ant_ser_apply_no")]
        public string AntSerApplyNo { get; set; }

        /// <summary>
        /// 支付宝的服务合约编号
        /// </summary>
        [XmlElement("ant_ser_contract_no")]
        public string AntSerContractNo { get; set; }

        /// <summary>
        /// 用户绑卡时间
        /// </summary>
        [XmlElement("bind_card_time")]
        public string BindCardTime { get; set; }

        /// <summary>
        /// 用户绑定的实体卡ICCID
        /// </summary>
        [XmlElement("iccid")]
        public string Iccid { get; set; }

        /// <summary>
        /// 实体卡SIMNO
        /// </summary>
        [XmlElement("sim_no")]
        public string SimNo { get; set; }
    }
}
