using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEtccardBindConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEtccardBindConsultModel : AopObject
    {
        /// <summary>
        /// 停车服务商id
        /// </summary>
        [XmlElement("isv_id")]
        public string IsvId { get; set; }

        /// <summary>
        /// 绑卡资格验证电话号码
        /// </summary>
        [XmlElement("mobile_no")]
        public string MobileNo { get; set; }

        /// <summary>
        /// 绑卡资格校验车牌号
        /// </summary>
        [XmlElement("plate_no")]
        public string PlateNo { get; set; }
    }
}
