using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpOpporFeedbackModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpOpporFeedbackModifyModel : AopObject
    {
        /// <summary>
        /// 拓展助手商机拓展结果
        /// </summary>
        [XmlElement("expand_result")]
        public string ExpandResult { get; set; }

        /// <summary>
        /// 服务商pid
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 商机id
        /// </summary>
        [XmlElement("leads_id")]
        public string LeadsId { get; set; }

        /// <summary>
        /// 拓展助手商机商家pid
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 商机作业id
        /// </summary>
        [XmlElement("oppor_id")]
        public string OpporId { get; set; }

        /// <summary>
        /// 拓展设备sn号
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }
    }
}
