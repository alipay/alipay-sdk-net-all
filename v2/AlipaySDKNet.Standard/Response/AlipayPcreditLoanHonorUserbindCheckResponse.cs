using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanHonorUserbindCheckResponse.
    /// </summary>
    public class AlipayPcreditLoanHonorUserbindCheckResponse : AopResponse
    {
        /// <summary>
        /// 准入状态，1-允许绑定，0-拒绝绑定
        /// </summary>
        [XmlElement("access")]
        public long Access { get; set; }

        /// <summary>
        /// 可用支付宝账号列表
        /// </summary>
        [XmlArray("account_list")]
        [XmlArrayItem("honor_alipay_account_model")]
        public List<HonorAlipayAccountModel> AccountList { get; set; }

        /// <summary>
        /// 绑定检查id，准入时有
        /// </summary>
        [XmlElement("bind_check_serial_no")]
        public string BindCheckSerialNo { get; set; }

        /// <summary>
        /// 准入失败原因码 01：无关联账号 02：实名信息不一致 03：身份信息失效 04：其他原因
        /// </summary>
        [XmlElement("fail_code")]
        public string FailCode { get; set; }

        /// <summary>
        /// 准入失败原因
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 准入失败具体原因
        /// </summary>
        [XmlElement("refuse_msg_data")]
        public string RefuseMsgData { get; set; }
    }
}
