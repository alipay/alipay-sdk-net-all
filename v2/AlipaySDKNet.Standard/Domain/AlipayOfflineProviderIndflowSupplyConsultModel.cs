using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderIndflowSupplyConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderIndflowSupplyConsultModel : AopObject
    {
        /// <summary>
        /// 业务参数
        /// </summary>
        [XmlElement("biz_info")]
        public IndflowBizInfo BizInfo { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("mobile_phone")]
        public string MobilePhone { get; set; }

        /// <summary>
        /// 由BD分配，展位外部ID
        /// </summary>
        [XmlElement("out_pos_id")]
        public string OutPosId { get; set; }

        /// <summary>
        /// 样式类型
        /// </summary>
        [XmlElement("style_type")]
        public string StyleType { get; set; }
    }
}
